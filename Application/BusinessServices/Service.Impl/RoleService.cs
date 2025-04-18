

using Domain.Entity;

namespace Application.BusinessServices
{
    public class RoleService(IRoleRepository repository, IMapper mapper) : IRoleService
    {
        private readonly IRoleRepository _repository = repository;
        private readonly IMapper _mapper = mapper;
        public async Task<int> DeleteAsync<Type>(Type Id)
        {
            return await _repository.DeleteAsync(Id);
        }

        public async Task<Results<IEnumerable<RoleDTO>>> GetAllAsync()
        {
            return SuccessResult.Success(_mapper.Map<IEnumerable<RoleDTO>>(await _repository.GetAllAsync()));
        }

        public async Task<Results<RoleDTO>> GetByIdAsync(Guid id)
        {
            return SuccessResult.Success(_mapper.Map<RoleDTO>(await _repository.GetByIdAsync(id)));
        }

        public async Task<int> InsertAsync(RoleDTO value)
        {
            return await _repository.InsertAsync(_mapper.Map<Role>(value));
        }

        public async Task<int> UpdateAsync(RoleDTO value)
        {
            return await _repository.UpdateAsync(_mapper.Map<Role>(value));
        }


    }
}
