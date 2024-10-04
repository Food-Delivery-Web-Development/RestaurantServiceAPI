namespace Restaurant.Service.Repositories.Concretes;

using Bases;
using Context;
using Domain.Concretes;

public class AddressRepository(PostgresContext context) : BaseRepository<Address>(context) { }
