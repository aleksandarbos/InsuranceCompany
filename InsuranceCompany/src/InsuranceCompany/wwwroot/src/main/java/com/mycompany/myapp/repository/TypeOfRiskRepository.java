package com.mycompany.myapp.repository;

import com.mycompany.myapp.domain.TypeOfRisk;

import org.springframework.data.jpa.repository.*;

import java.util.List;

/**
 * Spring Data JPA repository for the TypeOfRisk entity.
 */
@SuppressWarnings("unused")
public interface TypeOfRiskRepository extends JpaRepository<TypeOfRisk,Long> {

}
