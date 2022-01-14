using System;

namespace coodesh_desafio.Interfaces
{
    public interface IProvider
    {
        public Guid Id { get; set; }
        public string Provider { get; set; }
    }
}
