using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Contexts;
using AutoMapper;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Company.Data.Services;

public class DbService : IDbService
{
    private readonly CompanyContext _db;
    private readonly IMapper _mapper;
    public DbService(CompanyContext db, IMapper mapper) =>
    (_db, _mapper) = (db, mapper);

    public async Task<TEntity> AddAsync<TEntity, TDto>(TDto dto)
        where TEntity : class
        where TDto : class
    {
        var entity = _mapper.Map<TEntity>(dto);
        await _db.Set<TEntity>().AddAsync(entity);
        return entity;
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _db.SaveChangesAsync() >= 0;
    }

    async Task<bool> IDbService.AnyAsync<TEntity>(Expression<Func<TEntity, bool>> expression)
    {
        return await _db.Set<TEntity>().AnyAsync(expression);
    }

    async Task<List<TDto>> IDbService.GetAsync<TEntity, TDto>()
    {
        var entities = await _db.Set<TEntity>().ToListAsync();
        return _mapper.Map<List<TDto>>(entities);
    }

    private async Task<TEntity?> SingleAsync<TEntity>(Expression<Func<TEntity,
        bool>> expression) where TEntity : class, IEntity =>
         await _db.Set<TEntity>().SingleOrDefaultAsync(expression);

    async Task<TDto> IDbService.SingleAsync<TEntity, TDto>(Expression<Func<TEntity, bool>> expression)
    {
        var entities = await SingleAsync(expression);
        return _mapper.Map<TDto>(entities);
    }

    void IDbService.Update<TEntity, TDto>(int id, TDto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);
        _db.Set<TEntity>().Update(entity);
    }

    public async Task<bool> DeleteAsync<TEntity>(int id)
            where TEntity : class, IEntity

    {
        try
        {
            var entity = await SingleAsync<TEntity>(e => e.id.Equals(id));
            if (entity is null) return false;

            _db.Remove(entity);
        }
        catch (Exception )
        {

            return false;
        }
        return true;
    }

    bool IDbService.Delete<TReferenceEntity, TDto>(TDto dto) where TReferenceEntity : class where TDto : class

    {
        try
        {
            var entity = _mapper.Map<TReferenceEntity>(dto);
            if (entity is null) return false;

            _db.Remove(entity);
        }
        catch { throw; }
        return true;
    }
}
