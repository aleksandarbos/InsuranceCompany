package com.mycompany.myapp.service;

import com.mycompany.myapp.domain.Bank;

import java.util.List;

/**
 * Service Interface for managing Bank.
 */
public interface BankService {

    /**
     * Save a bank.
     *
     * @param bank the entity to save
     * @return the persisted entity
     */
    Bank save(Bank bank);

    /**
     *  Get all the banks.
     *  
     *  @return the list of entities
     */
    List<Bank> findAll();

    /**
     *  Get the "id" bank.
     *
     *  @param id the id of the entity
     *  @return the entity
     */
    Bank findOne(Long id);

    /**
     *  Delete the "id" bank.
     *
     *  @param id the id of the entity
     */
    void delete(Long id);
}
