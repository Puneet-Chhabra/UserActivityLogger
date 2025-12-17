using UserActivityLogger.Models;

namespace UserActivityLogger.Interfaces
{
    public interface IActivityServices
    {
        public void LogActivity(Activity activity);
        public List<Activity> GetAllActivities();
        public List<Activity> GetActivityByUser(int userId);
        public List<Activity> GetActivityByType(string type);
        public Activity LatestActivity();
    }
}