using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using Shared.DataTransferObjects;
using System.Text;

namespace HamsterWars2
{
    public class CsvOutputFormatter : TextOutputFormatter
    {
        public CsvOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/csv"));
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }
        protected override bool CanWriteType(Type? type)
        {
            if (typeof(HamsterDto).IsAssignableFrom(type) ||
           typeof(IEnumerable<HamsterDto>).IsAssignableFrom(type))
            {
                return base.CanWriteType(type);
            }
            return false;
        }
        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext
       context, Encoding selectedEncoding)
        {
            var response = context.HttpContext.Response;
            var buffer = new StringBuilder();
            if (context.Object is IEnumerable<HamsterDto>)
            {
                foreach (var company in (IEnumerable<HamsterDto>)context.Object)
                {
                    FormatCsv(buffer, company);
                }
            }
            else
            {
                FormatCsv(buffer, (HamsterDto)context.Object);
            }

            
        await response.WriteAsync(buffer.ToString());
        }
        private static void FormatCsv(StringBuilder buffer, HamsterDto hamster)
        {
            buffer.AppendLine($"{hamster.Id},\"{hamster.Name},\"{hamster.Games}\"");
            //Orka skriva ut mer.. :)
        }
    }

}
