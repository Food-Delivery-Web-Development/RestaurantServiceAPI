INSERT INTO restaurant (id, name, branch, logo_url)
  VALUES 
  ('90148ab8-d8b7-4be4-841f-5c746e59fb92', 'La Cochalita', 'Filial Principal', 'https://menu.sluurpy.com/immagini/locali/thumbs/5480122.jpg'), 
  ('a55865c0-6049-4fea-896c-4c3b9f3f76ae', 'El Rincon', 'Filial Principal', 'https://www.boliviaentusmanos.com/amarillas1/businesscard/imagenes/la-kantuta-restaurant-2.jpg');

INSERT INTO address (id, street, city, country, restaurant_id) 
  VALUES 
  ('6cee6fe6-cee5-4432-84b8-caca6bf89b6f', 'Calle 11', 'Cochabamba', 'Bolivia', '90148ab8-d8b7-4be4-841f-5c746e59fb92'), 
  ('632d044d-0716-4572-8be1-8cc52d19d22e', 'Calle 15', 'La Paz', 'Bolivia', 'a55865c0-6049-4fea-896c-4c3b9f3f76ae');

INSERT INTO product (id, name, description, price, image_url, restaurant_id)
  VALUES
  ('3a679ff7-1f10-4424-887f-d8193167d9a6', 'Pique Macho', 'El pique macho es más que un simple plato; es una fiesta de sabores que celebra la diversidad y riqueza de la cocina boliviana.', 60.00, 'https://platostipicosdecochabamba.com/wp-content/uploads/2023/09/pique-macho.jpg', '90148ab8-d8b7-4be4-841f-5c746e59fb92'),
  ('2966ba55-6f14-4fa1-a03d-eecbeabd544b', 'Chicharrón de Chancho', 'Este plato, venerado por su sabor profundo y su textura crujiente, es una verdadera celebración de la cocina boliviana, que combina ingredientes autóctonos y técnicas ancestrales.', 50.00, 'https://www.sacaba.gob.bo/images/wsacaba/turismo/gastronomia/chicharron-sacaba1.jpg', '90148ab8-d8b7-4be4-841f-5c746e59fb92'),
  ('e1a88a59-1d3a-434c-b445-7255e1cb74b0', 'Chairo', 'El chairo paceño es un plato tradicional lleno de sabor y cultura.', 25.00, 'https://placeresbolivia.com/wp-content/uploads/2021/09/CHAIRO-PACENO.jpg', 'a55865c0-6049-4fea-896c-4c3b9f3f76ae'),
  ('5dcbd88a-fd1e-4617-8bc9-323a8f92dd44', 'Plato Paceño', 'Descubre el encanto de la gastronomía paceña con nuestra receta del Plato Paceño, un platillo tradicional de La Paz.', 40.00, 'https://azafranbolivia.com/wp-content/uploads/2022/07/plato-paceno-la-paz-bolivia-historia-origen-1024x683.jpg', 'a55865c0-6049-4fea-896c-4c3b9f3f76ae');