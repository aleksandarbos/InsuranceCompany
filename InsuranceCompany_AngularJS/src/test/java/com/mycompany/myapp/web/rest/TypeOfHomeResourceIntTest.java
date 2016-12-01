package com.mycompany.myapp.web.rest;

import com.mycompany.myapp.InsuranceFeApp;

import com.mycompany.myapp.domain.TypeOfHome;
import com.mycompany.myapp.repository.TypeOfHomeRepository;
import com.mycompany.myapp.service.TypeOfHomeService;

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
 * Test class for the TypeOfHomeResource REST controller.
 *
 * @see TypeOfHomeResource
 */
@RunWith(SpringRunner.class)
@SpringBootTest(classes = InsuranceFeApp.class)
public class TypeOfHomeResourceIntTest {

    private static final String DEFAULT_NAME = "AAAAAAAAAA";
    private static final String UPDATED_NAME = "BBBBBBBBBB";

    @Inject
    private TypeOfHomeRepository typeOfHomeRepository;

    @Inject
    private TypeOfHomeService typeOfHomeService;

    @Inject
    private MappingJackson2HttpMessageConverter jacksonMessageConverter;

    @Inject
    private PageableHandlerMethodArgumentResolver pageableArgumentResolver;

    @Inject
    private EntityManager em;

    private MockMvc restTypeOfHomeMockMvc;

    private TypeOfHome typeOfHome;

    @Before
    public void setup() {
        MockitoAnnotations.initMocks(this);
        TypeOfHomeResource typeOfHomeResource = new TypeOfHomeResource();
        ReflectionTestUtils.setField(typeOfHomeResource, "typeOfHomeService", typeOfHomeService);
        this.restTypeOfHomeMockMvc = MockMvcBuilders.standaloneSetup(typeOfHomeResource)
            .setCustomArgumentResolvers(pageableArgumentResolver)
            .setMessageConverters(jacksonMessageConverter).build();
    }

    /**
     * Create an entity for this test.
     *
     * This is a static method, as tests for other entities might also need it,
     * if they test an entity which requires the current entity.
     */
    public static TypeOfHome createEntity(EntityManager em) {
        TypeOfHome typeOfHome = new TypeOfHome()
                .name(DEFAULT_NAME);
        return typeOfHome;
    }

    @Before
    public void initTest() {
        typeOfHome = createEntity(em);
    }

    @Test
    @Transactional
    public void createTypeOfHome() throws Exception {
        int databaseSizeBeforeCreate = typeOfHomeRepository.findAll().size();

        // Create the TypeOfHome

        restTypeOfHomeMockMvc.perform(post("/api/type-of-homes")
                .contentType(TestUtil.APPLICATION_JSON_UTF8)
                .content(TestUtil.convertObjectToJsonBytes(typeOfHome)))
                .andExpect(status().isCreated());

        // Validate the TypeOfHome in the database
        List<TypeOfHome> typeOfHomes = typeOfHomeRepository.findAll();
        assertThat(typeOfHomes).hasSize(databaseSizeBeforeCreate + 1);
        TypeOfHome testTypeOfHome = typeOfHomes.get(typeOfHomes.size() - 1);
        assertThat(testTypeOfHome.getName()).isEqualTo(DEFAULT_NAME);
    }

    @Test
    @Transactional
    public void checkNameIsRequired() throws Exception {
        int databaseSizeBeforeTest = typeOfHomeRepository.findAll().size();
        // set the field null
        typeOfHome.setName(null);

        // Create the TypeOfHome, which fails.

        restTypeOfHomeMockMvc.perform(post("/api/type-of-homes")
                .contentType(TestUtil.APPLICATION_JSON_UTF8)
                .content(TestUtil.convertObjectToJsonBytes(typeOfHome)))
                .andExpect(status().isBadRequest());

        List<TypeOfHome> typeOfHomes = typeOfHomeRepository.findAll();
        assertThat(typeOfHomes).hasSize(databaseSizeBeforeTest);
    }

    @Test
    @Transactional
    public void getAllTypeOfHomes() throws Exception {
        // Initialize the database
        typeOfHomeRepository.saveAndFlush(typeOfHome);

        // Get all the typeOfHomes
        restTypeOfHomeMockMvc.perform(get("/api/type-of-homes?sort=id,desc"))
                .andExpect(status().isOk())
                .andExpect(content().contentType(MediaType.APPLICATION_JSON_UTF8_VALUE))
                .andExpect(jsonPath("$.[*].id").value(hasItem(typeOfHome.getId().intValue())))
                .andExpect(jsonPath("$.[*].name").value(hasItem(DEFAULT_NAME.toString())));
    }

    @Test
    @Transactional
    public void getTypeOfHome() throws Exception {
        // Initialize the database
        typeOfHomeRepository.saveAndFlush(typeOfHome);

        // Get the typeOfHome
        restTypeOfHomeMockMvc.perform(get("/api/type-of-homes/{id}", typeOfHome.getId()))
            .andExpect(status().isOk())
            .andExpect(content().contentType(MediaType.APPLICATION_JSON_UTF8_VALUE))
            .andExpect(jsonPath("$.id").value(typeOfHome.getId().intValue()))
            .andExpect(jsonPath("$.name").value(DEFAULT_NAME.toString()));
    }

    @Test
    @Transactional
    public void getNonExistingTypeOfHome() throws Exception {
        // Get the typeOfHome
        restTypeOfHomeMockMvc.perform(get("/api/type-of-homes/{id}", Long.MAX_VALUE))
                .andExpect(status().isNotFound());
    }

    @Test
    @Transactional
    public void updateTypeOfHome() throws Exception {
        // Initialize the database
        typeOfHomeService.save(typeOfHome);

        int databaseSizeBeforeUpdate = typeOfHomeRepository.findAll().size();

        // Update the typeOfHome
        TypeOfHome updatedTypeOfHome = typeOfHomeRepository.findOne(typeOfHome.getId());
        updatedTypeOfHome
                .name(UPDATED_NAME);

        restTypeOfHomeMockMvc.perform(put("/api/type-of-homes")
                .contentType(TestUtil.APPLICATION_JSON_UTF8)
                .content(TestUtil.convertObjectToJsonBytes(updatedTypeOfHome)))
                .andExpect(status().isOk());

        // Validate the TypeOfHome in the database
        List<TypeOfHome> typeOfHomes = typeOfHomeRepository.findAll();
        assertThat(typeOfHomes).hasSize(databaseSizeBeforeUpdate);
        TypeOfHome testTypeOfHome = typeOfHomes.get(typeOfHomes.size() - 1);
        assertThat(testTypeOfHome.getName()).isEqualTo(UPDATED_NAME);
    }

    @Test
    @Transactional
    public void deleteTypeOfHome() throws Exception {
        // Initialize the database
        typeOfHomeService.save(typeOfHome);

        int databaseSizeBeforeDelete = typeOfHomeRepository.findAll().size();

        // Get the typeOfHome
        restTypeOfHomeMockMvc.perform(delete("/api/type-of-homes/{id}", typeOfHome.getId())
                .accept(TestUtil.APPLICATION_JSON_UTF8))
                .andExpect(status().isOk());

        // Validate the database is empty
        List<TypeOfHome> typeOfHomes = typeOfHomeRepository.findAll();
        assertThat(typeOfHomes).hasSize(databaseSizeBeforeDelete - 1);
    }
}
