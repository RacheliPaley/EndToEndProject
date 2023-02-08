using AutoMapper;
using Common.DTO_s;
using Repository.entities;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ChildService : IService<ChildDTO>
    {
        private readonly IMapper _mapper;
        private readonly IDataRepository<Child> _ChildRepository;
        public ChildService(IMapper mapper, IDataRepository<Child> ChildRepository)
        {
            _mapper = mapper;
            _ChildRepository = ChildRepository;
        }



        public async Task<ChildDTO> Add(ChildDTO entity)
        {
            return _mapper.Map<ChildDTO>(await _ChildRepository.AddAsync(_mapper.Map<Child>(entity)));
        }

        public async Task Delete(int id)
        {
            await _ChildRepository.DeleteAsync(id);

        }

        public async Task<List<ChildDTO>> GetAll()
        {
            return _mapper.Map<List<ChildDTO>>(await _ChildRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetById(int id)
        {
            return _mapper.Map<ChildDTO>(await _ChildRepository.GetByIdAsync(id));
        }

        public async Task<ChildDTO> Update(ChildDTO entity)
        {
            return _mapper.Map<ChildDTO>(await _ChildRepository.UpdateAsync(_mapper.Map<Child>(entity)));
        }

    }
}
