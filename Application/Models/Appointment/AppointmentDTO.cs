using Application.Models.Base;

namespace Application.Models
{
    public class AppointmentDTO : BaseNameEntityDTO
    {
        public required string Title { get; set; }
        public string? Details { get; set; }
        public EnumAppointmentType Type { get; set; }
        public DateTime? AppointmentTime { get; set; }

        public required string Email { get; set; }

        public Guid UserId { get; set; }

        public EnumStatus Status { get; set; } = EnumStatus.Upcoming;
    }
}
