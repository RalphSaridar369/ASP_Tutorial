using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMappers
    {
        public static CommentDto ToCommentDTO(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn.Date,
                StockId = commentModel.StockId,
            };
        }

        public static Comment ToCommentFromCreateDTO(this CreateCommentDto commentDto, int stockId)
        {
            return new CommentDto
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
                StockId = stockId,
            };
        }

    }
}