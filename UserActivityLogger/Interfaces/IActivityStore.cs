using UserActivityLogger.Models;

namespace UserActivityLogger.Interfaces
{
    public interface IActivityStore
    {
        public IReadOnlyList<Activity> GetActivities();

        public void AddActivity(Activity activity);
    }
}