package com.mycompany.myapp.repository;

import com.mycompany.myapp.domain.Bank;

import org.springframework.data.jpa.repository.*;

import java.util.List;

/**
 * Spring Data JPA repository for the Bank entity.
 */
@SuppressWarnings("unused")
public interface BankRepository extends JpaRepository<Bank,Long> {

}
