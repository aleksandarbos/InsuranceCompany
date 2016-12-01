package com.mycompany.myapp.web.rest;

import com.codahale.metrics.annotation.Timed;
import com.mycompany.myapp.domain.TypeOfHome;
import com.mycompany.myapp.service.TypeOfHomeService;
import com.mycompany.myapp.web.rest.util.HeaderUtil;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.inject.Inject;
import javax.validation.Valid;
import java.net.URI;
import java.net.URISyntaxException;
import java.util.List;
import java.util.Optional;

/**
 * REST controller for managing TypeOfHome.
 */
@RestController
@RequestMapping("/api")
public class TypeOfHomeResource {

    private final Logger log = LoggerFactory.getLogger(TypeOfHomeResource.class);
        
    @Inject
    private TypeOfHomeService typeOfHomeService;

    /**
     * POST  /type-of-homes : Create a new typeOfHome.
     *
     * @param typeOfHome the typeOfHome to create
     * @return the ResponseEntity with status 201 (Created) and with body the new typeOfHome, or with status 400 (Bad Request) if the typeOfHome has already an ID
     * @throws URISyntaxException if the Location URI syntax is incorrect
     */
    @PostMapping("/type-of-homes")
    @Timed
    public ResponseEntity<TypeOfHome> createTypeOfHome(@Valid @RequestBody TypeOfHome typeOfHome) throws URISyntaxException {
        log.debug("REST request to save TypeOfHome : {}", typeOfHome);
        if (typeOfHome.getId() != null) {
            return ResponseEntity.badRequest().headers(HeaderUtil.createFailureAlert("typeOfHome", "idexists", "A new typeOfHome cannot already have an ID")).body(null);
        }
        TypeOfHome result = typeOfHomeService.save(typeOfHome);
        return ResponseEntity.created(new URI("/api/type-of-homes/" + result.getId()))
            .headers(HeaderUtil.createEntityCreationAlert("typeOfHome", result.getId().toString()))
            .body(result);
    }

    /**
     * PUT  /type-of-homes : Updates an existing typeOfHome.
     *
     * @param typeOfHome the typeOfHome to update
     * @return the ResponseEntity with status 200 (OK) and with body the updated typeOfHome,
     * or with status 400 (Bad Request) if the typeOfHome is not valid,
     * or with status 500 (Internal Server Error) if the typeOfHome couldnt be updated
     * @throws URISyntaxException if the Location URI syntax is incorrect
     */
    @PutMapping("/type-of-homes")
    @Timed
    public ResponseEntity<TypeOfHome> updateTypeOfHome(@Valid @RequestBody TypeOfHome typeOfHome) throws URISyntaxException {
        log.debug("REST request to update TypeOfHome : {}", typeOfHome);
        if (typeOfHome.getId() == null) {
            return createTypeOfHome(typeOfHome);
        }
        TypeOfHome result = typeOfHomeService.save(typeOfHome);
        return ResponseEntity.ok()
            .headers(HeaderUtil.createEntityUpdateAlert("typeOfHome", typeOfHome.getId().toString()))
            .body(result);
    }

    /**
     * GET  /type-of-homes : get all the typeOfHomes.
     *
     * @return the ResponseEntity with status 200 (OK) and the list of typeOfHomes in body
     */
    @GetMapping("/type-of-homes")
    @Timed
    public List<TypeOfHome> getAllTypeOfHomes() {
        log.debug("REST request to get all TypeOfHomes");
        return typeOfHomeService.findAll();
    }

    /**
     * GET  /type-of-homes/:id : get the "id" typeOfHome.
     *
     * @param id the id of the typeOfHome to retrieve
     * @return the ResponseEntity with status 200 (OK) and with body the typeOfHome, or with status 404 (Not Found)
     */
    @GetMapping("/type-of-homes/{id}")
    @Timed
    public ResponseEntity<TypeOfHome> getTypeOfHome(@PathVariable Long id) {
        log.debug("REST request to get TypeOfHome : {}", id);
        TypeOfHome typeOfHome = typeOfHomeService.findOne(id);
        return Optional.ofNullable(typeOfHome)
            .map(result -> new ResponseEntity<>(
                result,
                HttpStatus.OK))
            .orElse(new ResponseEntity<>(HttpStatus.NOT_FOUND));
    }

    /**
     * DELETE  /type-of-homes/:id : delete the "id" typeOfHome.
     *
     * @param id the id of the typeOfHome to delete
     * @return the ResponseEntity with status 200 (OK)
     */
    @DeleteMapping("/type-of-homes/{id}")
    @Timed
    public ResponseEntity<Void> deleteTypeOfHome(@PathVariable Long id) {
        log.debug("REST request to delete TypeOfHome : {}", id);
        typeOfHomeService.delete(id);
        return ResponseEntity.ok().headers(HeaderUtil.createEntityDeletionAlert("typeOfHome", id.toString())).build();
    }

}
