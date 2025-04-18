

//using Domain.Entity;

//namespace Application.BusinessServices
//{
//    public class CarService(ICarRepository repository, IMapper mapper) : ICarService
//    {
//        private readonly ICarRepository _repository = repository;
//         private readonly IMapper _mapper = mapper;
//        public async Task<int> DeleteAsync<Type>(Type Id)
//        {
//            return await _repository.DeleteAsync(Id);
//        }

//        public async Task<Results<IEnumerable<CarDTO>>> GetAllAsync()
//        {
//            return SuccessResult.Success(_mapper.Map<IEnumerable<CarDTO>>(await _repository.GetAllAsync()));
//        }

//        public async Task<Results<CarDTO>> GetByIdAsync(Guid id)
//        {
//            return SuccessResult.Success(_mapper.Map<CarDTO>(await _repository.GetByIdAsync(id)));
//        }

//        public async Task<int> InsertAsync(CarDTO value)
//        {
//            return await _repository.InsertAsync(_mapper.Map<Car>(value));
//        }

//        public async Task<int> UpdateAsync(CarDTO value)
//        {
//            return await _repository.UpdateAsync(_mapper.Map<Car>(value));
//        }

       
//    }
//}
