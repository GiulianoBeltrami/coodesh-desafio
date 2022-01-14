using coodesh_desafio.Interfaces;
using System;

namespace coodesh_desafio.Models
{
    public class LaunchesProvider : IProvider
    {
        public Guid Id { get; set; }
        public string Provider { get; set; }
    }
}
