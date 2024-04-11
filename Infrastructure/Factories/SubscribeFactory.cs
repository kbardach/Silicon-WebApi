using Infrastructure.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories
{
    public class SubscribeFactory
    {
        public static SubscribeEntity Create(SubscribeViewModel viewModel)
        {
            try
            {
                var datetime = DateTime.Now;

                return new SubscribeEntity
                {
                    Email = viewModel.Email,
                    DailyNewsletter = viewModel.DailyNewsletter,
                    AdvertisingUpdates = viewModel.AdvertisingUpdates,
                    WeekinReview = viewModel.WeekinReview,
                    EventUpdates = viewModel.EventUpdates,
                    StartupsWeekly = viewModel.StartupsWeekly,
                    Podcasts = viewModel.Podcasts,
                    Created = datetime,
                    Updated = datetime,
                };
            }
            catch { }
            return null!;
        }
    }
}
