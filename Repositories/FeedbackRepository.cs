using System;
using PieShop.Models;

namespace PieShop.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext dbContext;

        public FeedbackRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            this.dbContext.Feedbacks.Add(feedback);
            this.dbContext.SaveChanges();
        }
    }
}
