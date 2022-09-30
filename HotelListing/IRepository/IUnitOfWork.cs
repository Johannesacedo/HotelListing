using HotelListing.Data;
using System;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> CountryRepository { get; }
        IGenericRepository<Hotel> HotelRepository { get; }

        Task Save();
    }
}
