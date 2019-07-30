using System;
using PieShop.Models;

namespace PieShop.Repositories
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
