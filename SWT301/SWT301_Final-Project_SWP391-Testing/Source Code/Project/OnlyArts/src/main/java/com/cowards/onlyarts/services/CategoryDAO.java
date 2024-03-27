/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.cowards.onlyarts.services;

import com.cowards.onlyarts.core.DBContext;
import com.cowards.onlyarts.repositories.category.CategoryDTO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author ngocn
 */
public class CategoryDAO {

    private static final String GET_ALL
            = "SELECT [cate_id], [cate_name] "
            + "FROM Categories";

    private static CategoryDAO instance = null;

    private static final DBContext DB = DBContext.getInstance();

    private CategoryDAO() {
    }

    public static CategoryDAO getInstance() {
        if (instance == null) {
            instance = new CategoryDAO();
        }
        return instance;
    }

    private void logError(String message, Exception ex) {
        Logger.getLogger(OrderDAO.class.getName()).log(Level.SEVERE, message, ex);
    }

    public List<CategoryDTO> getAll() {
        Connection conn = null;
        PreparedStatement stm = null;
        ResultSet rs = null;
        List<CategoryDTO> list = new ArrayList<>();
        try {
            conn = DB.getConnection();
            stm = conn.prepareStatement(GET_ALL);
            rs = stm.executeQuery();
            while (rs.next()) {
                CategoryDTO categoryDTO = new CategoryDTO();
                categoryDTO.setCateId(rs.getString(1));
                categoryDTO.setCateName(rs.getString(2));
                list.add(categoryDTO);
            }
        } catch (SQLException e) {
            logError("Exception found on getAll() method", e);
        } finally {
            DB.closeResultSet(rs);
            DB.closeStatement(stm);
        }
        return list;
    }
}
