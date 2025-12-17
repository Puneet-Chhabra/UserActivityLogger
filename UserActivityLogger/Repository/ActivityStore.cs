using UserActivityLogger.Interfaces;
using UserActivityLogger.Models;

namespace UserActivityLogger.Repository
{
    public class ActivityStore : IActivityStore
    {
        private List<Activity> _activities = new List<Activity>();
        public void AddActivity(Activity activity)
        {
            _activities.Add(activity);
        }

        public IReadOnlyList<Activity> GetActivities()
        {
            return [.._activities];
        }
    }
}