using AutoMapper;
using BookStore.DataAccess.Interfaces;
using BookStore.Models.DTOs.VM;
using BookStore.Models.Entities;
using BookStore.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IRepository<Feedback, int> feedbackRepo;
        private readonly IMapper mapper;

        public FeedbackService(IRepository<Feedback, int> feedbackRepo, IMapper mapper)
        {
            this.feedbackRepo = feedbackRepo;
            this.mapper = mapper;
        }

        public void AddFeedback(FeedbackVM dto)
        {
            var entity = mapper.Map<Feedback>(dto);

            feedbackRepo.Add(entity);
        }

        public void DeleteFeedback(int id)
        {
            var entity = feedbackRepo.GetInstance(id);
            if (entity == null)
            {
                return;
            }
            feedbackRepo.Delete(entity);
        }

        public FeedbackVM GetFeedback(int id)
        {
            var entity = feedbackRepo.GetInstance(id);
            return mapper.Map<FeedbackVM>(entity);
        }

        public void UpdateFeedback(int id, FeedbackVM dto)
        {
            var entity = feedbackRepo.GetInstance(id);
            if (entity == null)
            {
                return;
            }
            mapper.Map(dto, entity);
            feedbackRepo.Update(entity);
        }
    }
}
