package com.mycompany.myapp.repository;

import com.mycompany.myapp.domain.TypeOfHome;

import org.springframework.data.jpa.repository.*;

import java.util.List;

/**
 * Spring Data JPA repository for the TypeOfHome entity.
 */
@SuppressWarnings("unused")
public interface TypeOfHomeRepository extends JpaRepository<TypeOfHome,Long> {

}
