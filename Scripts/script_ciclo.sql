-- declaramos el nivel
declare @nivel int = 1
-- declaramos el orden
declare @orden int = 1
-- iniciamos ciclos
while (@nivel < 7)
begin
	set @orden = 1
	while (@orden < 7)
	begin
		-- algo
		Print 'Nivel: ' + Cast(@nivel as Char(3)) + 'Orden: ' + Cast(@orden as Char(3))
		set @orden = @orden + 1
	end
	set @nivel = @nivel + 1
end
go

/*
Nivel: 1  Orden: 1  
Nivel: 1  Orden: 2  
Nivel: 1  Orden: 3  
Nivel: 1  Orden: 4  
Nivel: 1  Orden: 5  
Nivel: 1  Orden: 6  
Nivel: 2  Orden: 1  
Nivel: 2  Orden: 2  
Nivel: 2  Orden: 3  
Nivel: 2  Orden: 4  
Nivel: 2  Orden: 5  
Nivel: 2  Orden: 6  
Nivel: 3  Orden: 1  
Nivel: 3  Orden: 2  
Nivel: 3  Orden: 3  
Nivel: 3  Orden: 4  
Nivel: 3  Orden: 5  
Nivel: 3  Orden: 6  
Nivel: 4  Orden: 1  
Nivel: 4  Orden: 2  
Nivel: 4  Orden: 3  
Nivel: 4  Orden: 4  
Nivel: 4  Orden: 5  
Nivel: 4  Orden: 6  
Nivel: 5  Orden: 1  
Nivel: 5  Orden: 2  
Nivel: 5  Orden: 3  
Nivel: 5  Orden: 4  
Nivel: 5  Orden: 5  
Nivel: 5  Orden: 6  
Nivel: 6  Orden: 1  
Nivel: 6  Orden: 2  
Nivel: 6  Orden: 3  
Nivel: 6  Orden: 4  
Nivel: 6  Orden: 5  
Nivel: 6  Orden: 6
*/