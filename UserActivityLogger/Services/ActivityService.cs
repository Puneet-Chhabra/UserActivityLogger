using UserActivityLogger.Models;
using UserActivityLogger.Interfaces;

namespace UserActivityLogger.Services
{
    public class ActivityService : IActivityServices
    {
        IActivityStore _activityStore;
        public ActivityService(IActivityStore activityStore)
        {
            _activityStore = activityStore;
        }
        public void LogActivity(Activity activity)
        {
            if(activity == null)return;
            _activityStore.AddActivity(activity);
            return ;
        }

        public List<Activity> GetAllActivities()
        {
            List<Activity> activities = _activityStore.GetActivities().ToList();
            return [.. activities];
        }

        public List<Activity> GetActivityByUser(int userId)
        {
            List<Activity> userActivities = _activityStore.GetActivities().ToList().FindAll(a=> a.UserId==userId);
            return [..userActivities];
        }
        
        public List<Activity> GetActivityByType(string type)
        {
            List<Activity> userActivities = _activityStore.GetActivities().ToList().FindAll(a=> a.ActivityType==type);
            return [..userActivities];
        }
        public Activity LatestActivity()
        {
            List<Activity> activities = _activityStore.GetActivities().ToList();
            if(activities.Count==0)throw new Exception("No Activities exists");
            return activities.OrderBy(activity=> activity.TimeStamp).Last();
        }
    }
}