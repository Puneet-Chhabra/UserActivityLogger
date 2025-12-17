namespace UserActivityLogger.Models
{
    public class Activity
    {
        public int Id{get;set;}
        public int UserId{get;set;}
        public required string ActivityType{get;set;}
        public TimeOnly TimeStamp{get;set;}
    }
}