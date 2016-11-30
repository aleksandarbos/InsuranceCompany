package com.mycompany.myapp.service;

import com.mycompany.myapp.domain.TypeOfHome;

import java.util.List;

/**
 * Service Interface for managing TypeOfHome.
 */
public interface TypeOfHomeService {

    /**
     * Save a typeOfHome.
     *
     * @param typeOfHome the entity to save
     * @return the persisted entity
     */
    TypeOfHome save(TypeOfHome typeOfHome);

    /**
     *  Get all the typeOfHomes.
     *  
     *  @return the list of entities
     */
    List<TypeOfHome> findAll();

    /**
     *  Get the "id" typeOfHome.
     *
     *  @param id the id of the entity
     *  @return the entity
     */
    TypeOfHome findOne(Long id);

    /**
     *  Delete the "id" typeOfHome.
     *
     *  @param id the id of the entity
     */
    void delete(Long id);
}
