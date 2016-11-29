package com.mycompany.myapp.service;

import com.mycompany.myapp.domain.TypeOfRisk;

import java.util.List;

/**
 * Service Interface for managing TypeOfRisk.
 */
public interface TypeOfRiskService {

    /**
     * Save a typeOfRisk.
     *
     * @param typeOfRisk the entity to save
     * @return the persisted entity
     */
    TypeOfRisk save(TypeOfRisk typeOfRisk);

    /**
     *  Get all the typeOfRisks.
     *  
     *  @return the list of entities
     */
    List<TypeOfRisk> findAll();

    /**
     *  Get the "id" typeOfRisk.
     *
     *  @param id the id of the entity
     *  @return the entity
     */
    TypeOfRisk findOne(Long id);

    /**
     *  Delete the "id" typeOfRisk.
     *
     *  @param id the id of the entity
     */
    void delete(Long id);
}
