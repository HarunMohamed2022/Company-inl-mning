using Company.Data.Interfaces;

namespace Company.API.Extensions;

public static class HttpExtensions
{
    public static async Task<IResult> HttpGetAsync<TEntity, TDto>(this IDbService db)
       where TEntity : class, IEntity where TDto : class => Results.Ok(await db.GetAsync<TEntity, TDto>());

    public static async Task<IResult> HttpGetSingleAsync<TEntity, TDto>(this IDbService db, int id)
        where TEntity : class, IEntity where TDto : class
    {
        var entity = await db.SingleAsync<TEntity, TDto>(e => e.id.Equals(id));
        return Results.Ok(entity);
    }

    public static async Task<IResult> HttpPost<TEntity, TDto>(this IDbService db, TDto dto)
       where TEntity : class, IEntity where TDto : class
    {
        try
        {
            var entity = await db.AddAsync<TEntity, TDto>(dto);
            if (await db.SaveChangesAsync())
            {
                var node = typeof(TEntity).Name.ToLower();
                return Results.Created($"/{node}s/{entity.id}", entity);
            }
        }
        catch (Exception ex)
        {
            return Results.BadRequest($"Couldn't add the {typeof(TEntity).Name}entity.\n{ex}.");
        }
        return Results.BadRequest();
    }

    public static async Task<IResult> HttpPut<TEntity, TDto>(this IDbService db, int id, TDto dto)
       where TEntity : class, IEntity where TDto : class
    {
        try
        {
            if (!await db.AnyAsync<TEntity>(e => e.id.Equals(id))) return
            Results.NotFound();
            db.Update<TEntity, TDto>(id, dto);
            if (await db.SaveChangesAsync()) return Results.NoContent();

        }
        catch (Exception ex)
        {

            return Results.BadRequest($"Couldn't update the {typeof(TEntity).Name}entity.\n{ex}.");
        }
        return Results.BadRequest();
    }

    public static async Task<IResult> HttpDeleteAsync<TEntity>(this IDbService db, int id)
        where TEntity : class, IEntity
    {
        try
        {
            var success = await db.DeleteAsync<TEntity>(id);
            if (success && await db.SaveChangesAsync())
                return Results.NoContent();


        }
        catch { }

        return Results.BadRequest();
    }

    public static async Task<IResult> HttpDelete<TEntity>(this IDbService db, int id)
        where TEntity : class, IEntity
    {
        try
        {
            var success = await db.DeleteAsync<TEntity>(id);
            if (success && await db.SaveChangesAsync())
                return Results.NoContent();


        }
        catch { }

        return Results.BadRequest();
    }
}
