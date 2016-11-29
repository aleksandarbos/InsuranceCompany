package com.mycompany.myapp.web.rest;

import com.mycompany.myapp.InsuranceFeApp;

import com.mycompany.myapp.domain.TypeOfRisk;
import com.mycompany.myapp.repository.TypeOfRiskRepository;
import com.mycompany.myapp.service.TypeOfRiskService;

import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import static org.hamcrest.Matchers.hasItem;
import org.mockito.MockitoAnnotations;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.http.MediaType;
import org.springframework.http.converter.json.MappingJackson2HttpMessageConverter;
import org.springframework.data.web.PageableHandlerMethodArgumentResolver;
import org.springframework.test.context.junit4.SpringRunner;
import org.springframework.test.util.ReflectionTestUtils;
import org.springframework.test.web.servlet.MockMvc;
import org.springframework.test.web.servlet.setup.MockMvcBuilders;
import org.springframework.transaction.annotation.Transactional;

import javax.inject.Inject;
import javax.persistence.EntityManager;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.*;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.*;

/**
 * Test class for the TypeOfRiskResource REST controller.
 *
 * @see TypeOfRiskResource
 */
@RunWith(SpringRunner.class)
@SpringBootTest(classes = InsuranceFeApp.class)
public class TypeOfRiskResourceIntTest {

    private static final String DEFAULT_NAME = "AAAAAAAAAA";
    private static final String UPDATED_NAME = "BBBBBBBBBB";

    @Inject
    private TypeOfRiskRepository typeOfRiskRepository;

    @Inject
    private TypeOfRiskService typeOfRiskService;

    @Inject
    private MappingJackson2HttpMessageConverter jacksonMessageConverter;

    @Inject
    private PageableHandlerMethodArgumentResolver pageableArgumentResolver;

    @Inject
    private EntityManager em;

    private MockMvc restTypeOfRiskMockMvc;

    private TypeOfRisk typeOfRisk;

    @Before
    public void setup() {
        MockitoAnnotations.initMocks(this);
        TypeOfRiskResource typeOfRiskResource = new TypeOfRiskResource();
        ReflectionTestUtils.setField(typeOfRiskResource, "typeOfRiskService", typeOfRiskService);
        this.restTypeOfRiskMockMvc = MockMvcBuilders.standaloneSetup(typeOfRiskResource)
            .setCustomArgumentResolvers(pageableArgumentResolver)
            .setMessageConverters(jacksonMessageConverter).build();
    }

    /**
     * Create an entity for this test.
     *
     * This is a static method, as tests for other entities might also need it,
     * if they test an entity which requires the current entity.
     */
    public static TypeOfRisk createEntity(EntityManager em) {
        TypeOfRisk typeOfRisk = new TypeOfRisk()
                .name(DEFAULT_NAME);
        return typeOfRisk;
    }

    @Before
    public void initTest() {
        typeOfRisk = createEntity(em);
    }

    @Test
    @Transactional
    public void createTypeOfRisk() throws Exception {
        int databaseSizeBeforeCreate = typeOfRiskRepository.findAll().size();

        // Create the TypeOfRisk

        restTypeOfRiskMockMvc.perform(post("/api/type-of-risks")
                .contentType(TestUtil.APPLICATION_JSON_UTF8)
                .content(TestUtil.convertObjectToJsonBytes(typeOfRisk)))
                .andExpect(status().isCreated());

        // Validate the TypeOfRisk in the database
        List<TypeOfRisk> typeOfRisks = typeOfRiskRepository.findAll();
        assertThat(typeOfRisks).hasSize(databaseSizeBeforeCreate + 1);
        TypeOfRisk testTypeOfRisk = typeOfRisks.get(typeOfRisks.size() - 1);
        assertThat(testTypeOfRisk.getName()).isEqualTo(DEFAULT_NAME);
    }

    @Test
    @Transactional
    public void getAllTypeOfRisks() throws Exception {
        // Initialize the database
        typeOfRiskRepository.saveAndFlush(typeOfRisk);

        // Get all the typeOfRisks
        restTypeOfRiskMockMvc.perform(get("/api/type-of-risks?sort=id,desc"))
                .andExpect(status().isOk())
                .andExpect(content().contentType(MediaType.APPLICATION_JSON_UTF8_VALUE))
                .andExpect(jsonPath("$.[*].id").value(hasItem(typeOfRisk.getId().intValue())))
                .andExpect(jsonPath("$.[*].name").value(hasItem(DEFAULT_NAME.toString())));
    }

    @Test
    @Transactional
    public void getTypeOfRisk() throws Exception {
        // Initialize the database
        typeOfRiskRepository.saveAndFlush(typeOfRisk);

        // Get the typeOfRisk
        restTypeOfRiskMockMvc.perform(get("/api/type-of-risks/{id}", typeOfRisk.getId()))
            .andExpect(status().isOk())
            .andExpect(content().contentType(MediaType.APPLICATION_JSON_UTF8_VALUE))
            .andExpect(jsonPath("$.id").value(typeOfRisk.getId().intValue()))
            .andExpect(jsonPath("$.name").value(DEFAULT_NAME.toString()));
    }

    @Test
    @Transactional
    public void getNonExistingTypeOfRisk() throws Exception {
        // Get the typeOfRisk
        restTypeOfRiskMockMvc.perform(get("/api/type-of-risks/{id}", Long.MAX_VALUE))
                .andExpect(status().isNotFound());
    }

    @Test
    @Transactional
    public void updateTypeOfRisk() throws Exception {
        // Initialize the database
        typeOfRiskService.save(typeOfRisk);

        int databaseSizeBeforeUpdate = typeOfRiskRepository.findAll().size();

        // Update the typeOfRisk
        TypeOfRisk updatedTypeOfRisk = typeOfRiskRepository.findOne(typeOfRisk.getId());
        updatedTypeOfRisk
                .name(UPDATED_NAME);

        restTypeOfRiskMockMvc.perform(put("/api/type-of-risks")
                .contentType(TestUtil.APPLICATION_JSON_UTF8)
                .content(TestUtil.convertObjectToJsonBytes(updatedTypeOfRisk)))
                .andExpect(status().isOk());

        // Validate the TypeOfRisk in the database
        List<TypeOfRisk> typeOfRisks = typeOfRiskRepository.findAll();
        assertThat(typeOfRisks).hasSize(databaseSizeBeforeUpdate);
        TypeOfRisk testTypeOfRisk = typeOfRisks.get(typeOfRisks.size() - 1);
        assertThat(testTypeOfRisk.getName()).isEqualTo(UPDATED_NAME);
    }

    @Test
    @Transactional
    public void deleteTypeOfRisk() throws Exception {
        // Initialize the database
        typeOfRiskService.save(typeOfRisk);

        int databaseSizeBeforeDelete = typeOfRiskRepository.findAll().size();

        // Get the typeOfRisk
        restTypeOfRiskMockMvc.perform(delete("/api/type-of-risks/{id}", typeOfRisk.getId())
                .accept(TestUtil.APPLICATION_JSON_UTF8))
                .andExpect(status().isOk());

        // Validate the database is empty
        List<TypeOfRisk> typeOfRisks = typeOfRiskRepository.findAll();
        assertThat(typeOfRisks).hasSize(databaseSizeBeforeDelete - 1);
    }
}
