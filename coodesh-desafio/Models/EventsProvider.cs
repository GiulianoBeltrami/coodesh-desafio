using coodesh_desafio.Interfaces;
using System;

namespace coodesh_desafio.Models
{
    public class EventsProvider: IProvider
    {
        public Guid Id { get; set; }
        public string Provider { get; set; }
    }
}
