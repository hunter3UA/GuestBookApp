using AutoMapper;
using Gb.Application.Dtos.Comments;
using Gb.Application.Requests.Comments;
using Gb.Domain.DbEntities;
using Gb.Domain.Entities;

namespace Gb.Application.MappingProfiles
{
    public class CommentProfile:Profile
    {
        public CommentProfile()
        {
            CreateMap<AddCommentDto, AddCommentRequest>();
            CreateMap<AddCommentRequest, CommentDb>();
            CreateMap<CommentDb, CommentEntity>();
            CreateMap<CommentEntity, CommentDto>();
        }
    }
}