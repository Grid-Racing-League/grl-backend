﻿namespace GRL.Domain.Repositories;

/// <summary>
/// Generic base repository interface defining standard CRUD operations.
/// </summary>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
public interface IBaseRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// Retrieves an entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity.</param>
    /// <returns>The entity if found; otherwise, null.</returns>
    Task<TEntity?> GetByIdAsync(int id);

    /// <summary>
    /// Retrieves all entities.
    /// </summary>
    /// <returns>A collection of all entities.</returns>
    Task<IEnumerable<TEntity>> GetAllAsync();

    /// <summary>
    /// Adds a new entity to the repository.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    Task AddAsync(TEntity entity);

    /// <summary>
    /// Updates an existing entity in the repository.
    /// </summary>
    /// <param name="entity">The entity with updated values.</param>
    void Update(TEntity entity);

    /// <summary>
    /// Deletes an entity from the repository.
    /// </summary>
    /// <param name="entity">The entity to delete.</param>
    void Delete(TEntity entity);

    /// <summary>
    /// Persists all changes made in the repository to the data store.
    /// </summary>
    Task SaveChangesAsync();
}