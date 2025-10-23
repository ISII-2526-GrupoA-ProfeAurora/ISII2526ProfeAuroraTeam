using Xunit;
//no hay using del proyecto de Calculadora porque está todo en el mismo namespace por simplicidad

namespace AppForSEII2526.API.Controllers.Matematicas
{
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }

    public class CalculadoraTest {
        [Fact] //atributo declara un metodo de prueba que ejecuta el ejecutor de pruebas
        //public async Task sumar_test()
        public void Sumar_EntradasNumNaturales_DevuelveTrue()
        {
            //Arrange​ (preparacion ejecucion)
            var entradaA = 2;
            var entradaB = 3;
            var resultadoEsperado = 5;
            var calc = new Calculadora();
            //Act​ (realizacion de prueba)
            var resultadoActual = calc.Sumar(entradaA, entradaB);
            //Assert​ (verificacion del resultado esperado - OBLIGATORIO-)
            Assert.IsType<int>(resultadoActual);
            Assert.Equal(resultadoEsperado, resultadoActual);
        }
    }

}