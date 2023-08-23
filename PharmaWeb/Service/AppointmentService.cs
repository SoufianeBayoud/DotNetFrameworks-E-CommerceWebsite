using Microsoft.EntityFrameworkCore;
using PharmaWeb.Data;
using PharmaWeb.Models;
using PharmaWeb.Models.ViewModels;

namespace PharmaWeb.Service
{
    public class AppointmentService : IAppointmentService
    {

        private readonly ApplicationDbContext _context;

        public AppointmentService(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }


        //list of all appointments that have not been removed
        public IEnumerable<Appointment> GetAllAppointment()
        {
            return _context.Appointments.Where(x => !x.IsDeleted).ToList();
        }


        //Find appointement with id
        public Appointment GetAppointmentId(int id)
        {
            return _context.Appointments.Where(x => x.AfspraakID == id && !x.IsDeleted).SingleOrDefault();
        }


        //Make a new appointement
        public int CreateAppointmente(CreateAppointmentCommand cmd)
        {
            Appointment app = cmd.ToAppointment();
            _context.Appointments.Add(app);

            _context.SaveChanges();

            return app.AfspraakID;
        }

        //Methode for delete an appointement
        public bool DeleteAppointment(int id)
        {
            Appointment toDelete = _context.Appointments.Find(id);

            if (toDelete == null)
            {
                return false;
            }

            toDelete.IsDeleted = true;
            _context.Appointments.Remove(toDelete);
            _context.SaveChanges();

            return true;
        }

    }
}
