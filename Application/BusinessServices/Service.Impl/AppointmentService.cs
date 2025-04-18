using Domain.Entity;

namespace Application.BusinessServices
{
    public class AppointmentService(IAppointmentRepository repository, IMapper mapper) : IAppointmentService
    {
        private readonly IAppointmentRepository _repository = repository;
        private readonly IMapper _mapper = mapper;
        public async Task<int> DeleteAsync<Type>(Type Id)
        {
            return await _repository.DeleteAsync(Id);
        }

        public async Task<Results<IEnumerable<AppointmentDTO>>> GetAllAsync()
        {
            return SuccessResult.Success(_mapper.Map<IEnumerable<AppointmentDTO>>(await _repository.GetAllAsync()));
        }

        public async Task<Results<AppointmentDTO>> GetByIdAsync(Guid id)
        {
            return SuccessResult.Success(_mapper.Map<AppointmentDTO>(await _repository.GetByIdAsync(id)));
        }

        public async Task<int> InsertAsync(AppointmentDTO value)
        {
            return await _repository.InsertAsync(_mapper.Map<Appointment>(value));
        }

        public async Task<int> UpdateAsync(AppointmentDTO value)
        {
            return await _repository.UpdateAsync(_mapper.Map<Appointment>(value));
        }


    }
}
