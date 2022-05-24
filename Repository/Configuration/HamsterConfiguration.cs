using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class HamsterConfiguration : IEntityTypeConfiguration<Hamster>
    {
        public void Configure(EntityTypeBuilder<Hamster> builder)
        {
            builder.HasData
                (
                //Öppna varsamt
            #region SkapaHamstrar
                new Hamster
                {
                    Id = 1,
                    Name = "Rasmus",
                    Age = 1,
                    ImgName = "/images/hamsters/hamster-9.jpg",
                    Loves = "Hjulet",
                    FavFood = "Pizza"
                },
                new Hamster
                {
                    Id = 2,
                    Name = "Jimmy",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-8.jpg",
                    Loves = "Meetings",
                    FavFood = "Fika"
                },
                new Hamster
                {
                    Id = 3,
                    Name = "Claes",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-7.jpg",
                    Loves = "Intellisense",
                    FavFood = "Pancakes"
                },
                new Hamster
                {
                    Id = 4,
                    Name = "Korven",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-1.jpg",
                    Loves = "Korvar",
                    FavFood = "Korv"
                },
                new Hamster
                {
                    Id = 5,
                    Name = "Patrik",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-2.jpg",
                    Loves = "Jumping",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 6,
                    Name = "Pontus",
                    Age = 4,
                    ImgName = "/images/hamsters/hamster-3.jpg",
                    Loves = "Kvivksilver",
                    FavFood = "Bark"
                },
                new Hamster
                {
                    Id = 7,
                    Name = "Mikael",
                    Age = 7,
                    ImgName = "/images/hamsters/hamster-4.jpg",
                    Loves = "Berras Bio",
                    FavFood = "Popcorn"
                },
                new Hamster
                {
                    Id = 8,
                    Name = "Bävern",
                    Age = 10,
                    ImgName = "/images/hamsters/hamster-5.jpg",
                    Loves = "Träd",
                    FavFood = "Bark"
                },
                new Hamster
                {
                    Id = 9,
                    Name = "Kattis",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-6.jpg",
                    Loves = "Lekar",
                    FavFood = "Blötmat"
                },
                new Hamster
                {
                    Id = 10,
                    Name = "Hyaena",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-10.jpg",
                    Loves = "Kids",
                    FavFood = "FUZEON"
                },
                new Hamster
                {
                    Id = 11,
                    Name = "Kingfisher",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-11.jpg",
                    Loves = "Lekar",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 12,
                    Name = "Robin",
                    Age = 4,
                    ImgName = "/images/hamsters/hamster-12.jpg",
                    Loves = "Hjulet",
                    FavFood = "Bark"
                },
                new Hamster
                {
                    Id = 13,
                    Name = "Lynx",
                    Age = 1,
                    ImgName = "/images/hamsters/hamster-13.jpg",
                    Loves = "Lekar",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 14,
                    Name = "Duck",
                    Age = 1,
                    ImgName = "/images/hamsters/hamster-14.jpg",
                    Loves = "Lekar",
                    FavFood = "Bark"
                },
                new Hamster
                {
                    Id = 15,
                    Name = "Rhinoceros",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-15.jpg",
                    Loves = "Hjulet",
                    FavFood = "Blötmat"
                },
                new Hamster
                {
                    Id = 16,
                    Name = "Red",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-16.jpg",
                    Loves = "Lekar",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 17,
                    Name = "Gazelle",
                    Age = 1,
                    ImgName = "/images/hamsters/hamster-17.jpg",
                    Loves = "Hjulet",
                    FavFood = "Bark"
                },
                new Hamster
                {
                    Id = 18,
                    Name = "Dragon",
                    Age = 5,
                    ImgName = "/images/hamsters/hamster-18.jpg",
                    Loves = "Lekar",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 19,
                    Name = "Lourie",
                    Age = 4,
                    ImgName = "/images/hamsters/hamster-19.jpg",
                    Loves = "Lekar",
                    FavFood = "Blötmat"
                },
                new Hamster
                {
                    Id = 20,
                    Name = "Squirrel",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-20.jpg",
                    Loves = "Hjulet",
                    FavFood = "Bark"
                },
                new Hamster
                {
                    Id = 21,
                    Name = "Carmine",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-21.jpg",
                    Loves = "Lekar",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 22,
                    Name = "Snake",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-22.jpg",
                    Loves = "Hjulet",
                    FavFood = "Popcorn"
                },
                new Hamster
                {
                    Id = 23,
                    Name = "Bear",
                    Age = 1,
                    ImgName = "/images/hamsters/hamster-23.jpg",
                    Loves = "Lekar",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 24,
                    Name = "Chickadee",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-24.jpg",
                    Loves = "Hjulet",
                    FavFood = "Bark"
                },
                new Hamster
                {
                    Id = 25,
                    Name = "Vervet ",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-25.jpg",
                    Loves = "Lekar",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 26,
                    Name = "Malagasy ",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-26.jpg",
                    Loves = "Hjulet",
                    FavFood = "Bark"
                },
                new Hamster
                {
                    Id = 27,
                    Name = "Malleefowl",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-27.jpg",
                    Loves = "Lekar",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 28,
                    Name = "Desert",
                    Age = 1,
                    ImgName = "/images/hamsters/hamster-28.jpg",
                    Loves = "Hjulet",
                    FavFood = "Bark"
                },
                new Hamster
                {
                    Id = 29,
                    Name = "Kaffir",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-29.jpg",
                    Loves = "Lekar",
                    FavFood = "Popcorn"
                },
                new Hamster
                {
                    Id = 30,
                    Name = "Nubian ",
                    Age = 1,
                    ImgName = "/images/hamsters/hamster-30.jpg",
                    Loves = "Lekar",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 31,
                    Name = "Macaw",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-31.jpg",
                    Loves = "Hjulet",
                    FavFood = "Popcorn"
                },
                new Hamster
                {
                    Id = 32,
                    Name = "Woodcock",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-32.jpg",
                    Loves = "Lekar",
                    FavFood = "Blötmat"
                },
                new Hamster
                {
                    Id = 33,
                    Name = "Eurasian",
                    Age = 4,
                    ImgName = "/images/hamsters/hamster-33.jpg",
                    Loves = "Hjulet",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 34,
                    Name = "Mynah",
                    Age = 4,
                    ImgName = "/images/hamsters/hamster-34.jpg",
                    Loves = "Lekar",
                    FavFood = "Gräs"
                },
                new Hamster
                {
                    Id = 35,
                    Name = "Sportive",
                    Age = 4,
                    ImgName = "/images/hamsters/hamster-35.jpg",
                    Loves = "Lekar",
                    FavFood = "Popcorn"
                },
                new Hamster
                {
                    Id = 36,
                    Name = "Marten",
                    Age = 3,
                    ImgName = "/images/hamsters/hamster-36.jpg",
                    Loves = "Hjulet",
                    FavFood = "Gräs"
                },
                new Hamster
                {
                    Id = 37,
                    Name = "Malagasy",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-37.jpg",
                    Loves = "Lekar",
                    FavFood = "Sallad"
                },
                new Hamster
                {
                    Id = 38,
                    Name = "Grey ",
                    Age = 1,
                    ImgName = "/images/hamsters/hamster-38.jpg",
                    Loves = "Hjulet",
                    FavFood = "Popcorn"
                },
                new Hamster
                {
                    Id = 39,
                    Name = "Bear",
                    Age = 1,
                    ImgName = "/images/hamsters/hamster-39.jpg",
                    Loves = "Lekar",
                    FavFood = "Gräs"
                },
                new Hamster
                {
                    Id = 40,
                    Name = "Four",
                    Age = 2,
                    ImgName = "/images/hamsters/hamster-40.jpg",
                    Loves = "Hjulet",
                    FavFood = "Sallad"
                }
                );
#endregion
        }
    }
}
