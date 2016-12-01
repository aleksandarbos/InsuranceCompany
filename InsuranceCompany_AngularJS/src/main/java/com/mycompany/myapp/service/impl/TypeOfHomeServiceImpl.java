package com.mycompany.myapp.service.impl;

import com.mycompany.myapp.service.TypeOfHomeService;
import com.mycompany.myapp.domain.TypeOfHome;
import com.mycompany.myapp.repository.TypeOfHomeRepository;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.stereotype.Service;

import javax.inject.Inject;
import java.util.List;

/**
 * Service Implementation for managing TypeOfHome.
 */
@Service
@Transactional
public class TypeOfHomeServiceImpl implements TypeOfHomeService{

    private final Logger log = LoggerFactory.getLogger(TypeOfHomeServiceImpl.class);
    
    @Inject
    private TypeOfHomeRepository typeOfHomeRepository;

    /**
     * Save a typeOfHome.
     *
     * @param typeOfHome the entity to save
     * @return the persisted entity
     */
    public TypeOfHome save(TypeOfHome typeOfHome) {
        log.debug("Request to save TypeOfHome : {}", typeOfHome);
        TypeOfHome result = typeOfHomeRepository.save(typeOfHome);
        return result;
    }

    /**
     *  Get all the typeOfHomes.
     *  
     *  @return the list of entities
     */
    @Transactional(readOnly = true) 
    public List<TypeOfHome> findAll() {
        log.debug("Request to get all TypeOfHomes");
        List<TypeOfHome> result = typeOfHomeRepository.findAll();

        return result;
    }

    /**
     *  Get one typeOfHome by id.
     *
     *  @param id the id of the entity
     *  @return the entity
     */
    @Transactional(readOnly = true) 
    public TypeOfHome findOne(Long id) {
        log.debug("Request to get TypeOfHome : {}", id);
        TypeOfHome typeOfHome = typeOfHomeRepository.findOne(id);
        return typeOfHome;
    }

    /**
     *  Delete the  typeOfHome by id.
     *
     *  @param id the id of the entity
     */
    public void delete(Long id) {
        log.debug("Request to delete TypeOfHome : {}", id);
        typeOfHomeRepository.delete(id);
    }
}
