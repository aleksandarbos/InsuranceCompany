package com.mycompany.myapp.web.rest;

import com.codahale.metrics.annotation.Timed;
import com.mycompany.myapp.domain.TypeOfRisk;
import com.mycompany.myapp.service.TypeOfRiskService;
import com.mycompany.myapp.web.rest.util.HeaderUtil;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.inject.Inject;
import java.net.URI;
import java.net.URISyntaxException;
import java.util.List;
import java.util.Optional;

/**
 * REST controller for managing TypeOfRisk.
 */
@RestController
@RequestMapping("/api")
public class TypeOfRiskResource {

    private final Logger log = LoggerFactory.getLogger(TypeOfRiskResource.class);
        
    @Inject
    private TypeOfRiskService typeOfRiskService;

    /**
     * POST  /type-of-risks : Create a new typeOfRisk.
     *
     * @param typeOfRisk the typeOfRisk to create
     * @return the ResponseEntity with status 201 (Created) and with body the new typeOfRisk, or with status 400 (Bad Request) if the typeOfRisk has already an ID
     * @throws URISyntaxException if the Location URI syntax is incorrect
     */
    @PostMapping("/type-of-risks")
    @Timed
    public ResponseEntity<TypeOfRisk> createTypeOfRisk(@RequestBody TypeOfRisk typeOfRisk) throws URISyntaxException {
        log.debug("REST request to save TypeOfRisk : {}", typeOfRisk);
        if (typeOfRisk.getId() != null) {
            return ResponseEntity.badRequest().headers(HeaderUtil.createFailureAlert("typeOfRisk", "idexists", "A new typeOfRisk cannot already have an ID")).body(null);
        }
        TypeOfRisk result = typeOfRiskService.save(typeOfRisk);
        return ResponseEntity.created(new URI("/api/type-of-risks/" + result.getId()))
            .headers(HeaderUtil.createEntityCreationAlert("typeOfRisk", result.getId().toString()))
            .body(result);
    }

    /**
     * PUT  /type-of-risks : Updates an existing typeOfRisk.
     *
     * @param typeOfRisk the typeOfRisk to update
     * @return the ResponseEntity with status 200 (OK) and with body the updated typeOfRisk,
     * or with status 400 (Bad Request) if the typeOfRisk is not valid,
     * or with status 500 (Internal Server Error) if the typeOfRisk couldnt be updated
     * @throws URISyntaxException if the Location URI syntax is incorrect
     */
    @PutMapping("/type-of-risks")
    @Timed
    public ResponseEntity<TypeOfRisk> updateTypeOfRisk(@RequestBody TypeOfRisk typeOfRisk) throws URISyntaxException {
        log.debug("REST request to update TypeOfRisk : {}", typeOfRisk);
        if (typeOfRisk.getId() == null) {
            return createTypeOfRisk(typeOfRisk);
        }
        TypeOfRisk result = typeOfRiskService.save(typeOfRisk);
        return ResponseEntity.ok()
            .headers(HeaderUtil.createEntityUpdateAlert("typeOfRisk", typeOfRisk.getId().toString()))
            .body(result);
    }

    /**
     * GET  /type-of-risks : get all the typeOfRisks.
     *
     * @return the ResponseEntity with status 200 (OK) and the list of typeOfRisks in body
     */
    @GetMapping("/type-of-risks")
    @Timed
    public List<TypeOfRisk> getAllTypeOfRisks() {
        log.debug("REST request to get all TypeOfRisks");
        return typeOfRiskService.findAll();
    }

    /**
     * GET  /type-of-risks/:id : get the "id" typeOfRisk.
     *
     * @param id the id of the typeOfRisk to retrieve
     * @return the ResponseEntity with status 200 (OK) and with body the typeOfRisk, or with status 404 (Not Found)
     */
    @GetMapping("/type-of-risks/{id}")
    @Timed
    public ResponseEntity<TypeOfRisk> getTypeOfRisk(@PathVariable Long id) {
        log.debug("REST request to get TypeOfRisk : {}", id);
        TypeOfRisk typeOfRisk = typeOfRiskService.findOne(id);
        return Optional.ofNullable(typeOfRisk)
            .map(result -> new ResponseEntity<>(
                result,
                HttpStatus.OK))
            .orElse(new ResponseEntity<>(HttpStatus.NOT_FOUND));
    }

    /**
     * DELETE  /type-of-risks/:id : delete the "id" typeOfRisk.
     *
     * @param id the id of the typeOfRisk to delete
     * @return the ResponseEntity with status 200 (OK)
     */
    @DeleteMapping("/type-of-risks/{id}")
    @Timed
    public ResponseEntity<Void> deleteTypeOfRisk(@PathVariable Long id) {
        log.debug("REST request to delete TypeOfRisk : {}", id);
        typeOfRiskService.delete(id);
        return ResponseEntity.ok().headers(HeaderUtil.createEntityDeletionAlert("typeOfRisk", id.toString())).build();
    }

}
