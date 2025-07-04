﻿using System.Runtime.CompilerServices;
using GameStore.Contracts;
using GameStore.Entities;

namespace GameStore.Mapping
{
    public static class GenreMapping
    {
        public static GenreDto ToDto(this Genre genre)
        {
            return new GenreDto(genre.Id, genre.Name);
        }
    }
}
