

using PharmaWeb.Data;
using PharmaWeb.Models;
using PharmaWeb.Models.ViewModels;

namespace PharmaWeb.Service
{
    public interface IAppointmentService
    {
        public IEnumerable<Appointment> GetAllAppointment();
       
        public Appointment GetAppointmentId(int id);

        public int CreateAppointmente(CreateAppointmentCommand cmd);

        public bool DeleteAppointment(int id);
    }
}
