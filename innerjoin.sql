Select juego.descripcion, dimension.dimension,
categoria.categoria, imagen.imagen
from juego 
inner join dimension on juego.id_dimension=dimension.id_dimension
inner join categoria on juego.id_categoria=categoria.id_categoria 
inner join imagen on juego.id_imagen=imagen.id WHERE juego.estado = true AND categoria.id_categoria = 1 AND dimension.id_dimension = 1;