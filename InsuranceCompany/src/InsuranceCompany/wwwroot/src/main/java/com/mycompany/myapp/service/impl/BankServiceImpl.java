package com.mycompany.myapp.service.impl;

import com.mycompany.myapp.service.BankService;
import com.mycompany.myapp.domain.Bank;
import com.mycompany.myapp.repository.BankRepository;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.stereotype.Service;

import javax.inject.Inject;
import java.util.List;

/**
 * Service Implementation for managing Bank.
 */
@Service
@Transactional
public class BankServiceImpl implements BankService{

    private final Logger log = LoggerFactory.getLogger(BankServiceImpl.class);
    
    @Inject
    private BankRepository bankRepository;

    /**
     * Save a bank.
     *
     * @param bank the entity to save
     * @return the persisted entity
     */
    public Bank save(Bank bank) {
        log.debug("Request to save Bank : {}", bank);
        Bank result = bankRepository.save(bank);
        return result;
    }

    /**
     *  Get all the banks.
     *  
     *  @return the list of entities
     */
    @Transactional(readOnly = true) 
    public List<Bank> findAll() {
        log.debug("Request to get all Banks");
        List<Bank> result = bankRepository.findAll();

        return result;
    }

    /**
     *  Get one bank by id.
     *
     *  @param id the id of the entity
     *  @return the entity
     */
    @Transactional(readOnly = true) 
    public Bank findOne(Long id) {
        log.debug("Request to get Bank : {}", id);
        Bank bank = bankRepository.findOne(id);
        return bank;
    }

    /**
     *  Delete the  bank by id.
     *
     *  @param id the id of the entity
     */
    public void delete(Long id) {
        log.debug("Request to delete Bank : {}", id);
        bankRepository.delete(id);
    }
}
