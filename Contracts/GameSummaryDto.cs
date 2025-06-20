﻿using System.ComponentModel.DataAnnotations;

namespace GameStore.Contracts
{
    public record class GameSummaryDto(
        int Id, 
        [Required][StringLength(50)]string Name, 
        [Required][StringLength(20)]string Genre, 
        [Range(1,100)]decimal Price,
        DateOnly ReleaseDate);
}
