package com.mycompany.myapp.service.impl;

import com.mycompany.myapp.service.TypeOfRiskService;
import com.mycompany.myapp.domain.TypeOfRisk;
import com.mycompany.myapp.repository.TypeOfRiskRepository;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.stereotype.Service;

import javax.inject.Inject;
import java.util.List;

/**
 * Service Implementation for managing TypeOfRisk.
 */
@Service
@Transactional
public class TypeOfRiskServiceImpl implements TypeOfRiskService{

    private final Logger log = LoggerFactory.getLogger(TypeOfRiskServiceImpl.class);
    
    @Inject
    private TypeOfRiskRepository typeOfRiskRepository;

    /**
     * Save a typeOfRisk.
     *
     * @param typeOfRisk the entity to save
     * @return the persisted entity
     */
    public TypeOfRisk save(TypeOfRisk typeOfRisk) {
        log.debug("Request to save TypeOfRisk : {}", typeOfRisk);
        TypeOfRisk result = typeOfRiskRepository.save(typeOfRisk);
        return result;
    }

    /**
     *  Get all the typeOfRisks.
     *  
     *  @return the list of entities
     */
    @Transactional(readOnly = true) 
    public List<TypeOfRisk> findAll() {
        log.debug("Request to get all TypeOfRisks");
        List<TypeOfRisk> result = typeOfRiskRepository.findAll();

        return result;
    }

    /**
     *  Get one typeOfRisk by id.
     *
     *  @param id the id of the entity
     *  @return the entity
     */
    @Transactional(readOnly = true) 
    public TypeOfRisk findOne(Long id) {
        log.debug("Request to get TypeOfRisk : {}", id);
        TypeOfRisk typeOfRisk = typeOfRiskRepository.findOne(id);
        return typeOfRisk;
    }

    /**
     *  Delete the  typeOfRisk by id.
     *
     *  @param id the id of the entity
     */
    public void delete(Long id) {
        log.debug("Request to delete TypeOfRisk : {}", id);
        typeOfRiskRepository.delete(id);
    }
}
