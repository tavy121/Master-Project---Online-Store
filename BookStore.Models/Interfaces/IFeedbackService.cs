using BookStore.Models.DTOs.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Interfaces
{
    public interface IFeedbackService
    {

        FeedbackVM GetFeedback(int id);
        void AddFeedback(FeedbackVM dto);
        void UpdateFeedback(int id, FeedbackVM dto);
        void DeleteFeedback(int id);
    }
}
