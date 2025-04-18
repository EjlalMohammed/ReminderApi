

using Domain.Entity;

namespace Application.BusinessServices
{
    public class UserService(IUserRepository repository, IMapper mapper) : IUserService
    {
        private readonly IUserRepository _repository = repository;
        private readonly IMapper _mapper = mapper;
        public async Task<int> DeleteAsync<Type>(Type Id)
        {
            return await _repository.DeleteAsync(Id);
        }

        public async Task<Results<IEnumerable<UserDTO>>> GetAllAsync()
        {
            return SuccessResult.Success(_mapper.Map<IEnumerable<UserDTO>>(await _repository.GetAllAsync()));
        }

        public async Task<Results<UserDTO>> GetByIdAsync(Guid id)
        {
            return SuccessResult.Success(_mapper.Map<UserDTO>(await _repository.GetByIdAsync(id)));
        }

        public async Task<int> InsertAsync(UserDTO value)
        {
            return await _repository.InsertAsync(_mapper.Map<User>(value));
        }

        public async Task<int> UpdateAsync(UserDTO value)
        {
            return await _repository.UpdateAsync(_mapper.Map<User>(value));
        }


    }
}
