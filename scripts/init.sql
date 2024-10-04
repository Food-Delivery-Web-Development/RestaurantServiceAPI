CREATE TABLE IF NOT EXISTS restaurant (
    id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    name TEXT NOT NULL,
    branch TEXT NOT NULL,
    logo_url TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS address (
    id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    street TEXT NOT NULL,
    city TEXT NOT NULL,
    country TEXT NOT NULL,
    restaurant_id UUID NOT NULL UNIQUE,
    FOREIGN KEY (restaurant_id) REFERENCES restaurant(id)
);

CREATE TABLE IF NOT EXISTS product (
    id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    name TEXT NOT NULL,
    description TEXT NOT NULL,
    price DECIMAL NOT NULL,
    image_url TEXT NOT NULL,
    restaurant_id UUID NOT NULL,
    FOREIGN KEY (restaurant_id) REFERENCES restaurant(id)
);