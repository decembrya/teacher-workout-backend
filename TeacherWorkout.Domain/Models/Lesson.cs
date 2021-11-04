using TeacherWorkout.Domain.Common;

namespace TeacherWorkout.Domain.Models
{
    public class Lesson : IIdentifiable
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ThumbnailId { get; set; }
        public Image Thumbnail { get; set; }

        public string ThemeId { get; set; }
        public Theme Theme { get; set; }
        
        public Duration Duration { get; set; }

    }
}
