INSERT INTO address (id, street, city, country) 
  VALUES ('6cee6fe6-cee5-4432-84b8-caca6bf89b6f', 'Rua 1', 'Cidade 1', 'País 1'), 
  ('632d044d-0716-4572-8be1-8cc52d19d22e', 'Rua 2', 'Cidade 2', 'País 2');

INSERT INTO restaurant (id, name, branch, address_id)
  VALUES 
  ('90148ab8-d8b7-4be4-841f-5c746e59fb92', 'Restaurante 1', 'Filial 1', '6cee6fe6-cee5-4432-84b8-caca6bf89b6f'), 
  ('a55865c0-6049-4fea-896c-4c3b9f3f76ae', 'Restaurante 2', 'Filial 2', '632d044d-0716-4572-8be1-8cc52d19d22e');

INSERT INTO product (id, name, description, price, restaurant_id)
  VALUES
  ('3a679ff7-1f10-4424-887f-d8193167d9a6', 'Produto 1', 'Descripcion Producto 1', 10.00, '90148ab8-d8b7-4be4-841f-5c746e59fb92'),
  ('e1a88a59-1d3a-434c-b445-7255e1cb74b0', 'Produto 2', 'Descripcion Producto 2', 20.00, 'a55865c0-6049-4fea-896c-4c3b9f3f76ae'),
  ('2966ba55-6f14-4fa1-a03d-eecbeabd544b', 'Produto 3', 'Descripcion Producto 3', 30.00, '90148ab8-d8b7-4be4-841f-5c746e59fb92'),
  ('5dcbd88a-fd1e-4617-8bc9-323a8f92dd44', 'Produto 4', 'Descripcion Product 4', 40.00, 'a55865c0-6049-4fea-896c-4c3b9f3f76ae'),
  ('763b93f7-875f-4491-a445-38c5d9c1000d', 'Produto 5', 'Descripcion Product 5', 50.00, '90148ab8-d8b7-4be4-841f-5c746e59fb92'),
  ('e860e96a-b9bc-411a-b6fd-f8c8b0490b47', 'Produto 6', 'Descripcion producto 6', 60.00, 'a55865c0-6049-4fea-896c-4c3b9f3f76ae');