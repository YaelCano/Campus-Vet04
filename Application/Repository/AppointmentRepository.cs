using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository;
using Domain.entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories
{
    public class AppointmentRepository : GenericRepository<Appointment>,IAppointment
    {
        private readonly CampusVet4Context _context;
        public AppointmentRepository(CampusVet4Context context) : base(context)
        {
            _context = context;
        }
    }
}