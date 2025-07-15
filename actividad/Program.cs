// See https://aka.ms/new-console-template for more information
using System;

string nombreProducto;
var valorUnit = 0;
double iva = 0.19, pagoEfectivo = 0.10d, pagoDebito = 0.05d, pagoCredito = 0.22d;
var valorTotal = 0.0;
var cantidad = 0;
var subtotal = 0;

Console.WriteLine("Bienvenido a la tienda. \n");
Console.WriteLine("Productos de la tienda: \n");
Console.WriteLine("1. Camiseta ");
Console.WriteLine("2. Pantalon"); 
Console.WriteLine("3. Zapatillas");
Console.WriteLine("4. Gorra");
Console.WriteLine("5. Bufanda");


Console.WriteLine("Por favor ingrese El nombre del producto");
nombreProducto = Console.ReadLine();
switch (nombreProducto.ToLower())
{
    case "camiseta":

        Console.WriteLine("Por favor ingres el valor del producto(ingresarlos sin . ni ,): ");
        valorUnit = int.Parse(Console.ReadLine());
        if (valorUnit >= 0){
            Console.WriteLine($"Por favor ingrese la cantidad del {nombreProducto} que desea comprar:");
            cantidad = int.Parse(Console.ReadLine());
            if(cantidad >= 0){
                subtotal = valorUnit * cantidad;
                double totalIva = subtotal+(subtotal*iva);
                Console.WriteLine("¿Que forma de pago?(debito,credito o efectivo): ");
                string formaPago = Console.ReadLine().ToLower();
                if(formaPago == "debito")
                {
                    valorTotal = totalIva + (totalIva * pagoDebito);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Recargo por pago con {formaPago}: ${totalIva * pagoDebito}\n");

                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else if(formaPago == "credito")
                {
                    valorTotal = totalIva + (totalIva * pagoCredito);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Recargo por pago con {formaPago}: ${totalIva * pagoCredito}\n");

                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else if(formaPago == "efectivo")
                {
                    valorTotal = totalIva - (totalIva * pagoEfectivo);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Descuento por pago con {formaPago}: ${totalIva * pagoEfectivo}\n");


                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else
                {
                    Console.WriteLine("Forma de pago no reconocida.");

                }



            }
            else
            Console.WriteLine("El valor del producto no puede ser negativo.");
        }
        else
            Console.WriteLine("El valor del producto no puede ser negativo.");
        
        break;
    case "pantalon":

        Console.WriteLine("Por favor ingres el valor del producto(ingresarlos sin . ni ,): ");
        valorUnit = int.Parse(Console.ReadLine());
        if (valorUnit >= 0){
            Console.WriteLine($"Por favor ingrese la cantidad del {nombreProducto} que desea comprar:");
            cantidad = int.Parse(Console.ReadLine());
            if(cantidad >= 0){
                subtotal = valorUnit * cantidad;
                double totalIva = subtotal+(subtotal*iva);
                Console.WriteLine("¿Que forma de pago?(debito,credito o efectivo): ");
                string formaPago = Console.ReadLine().ToLower();
                if(formaPago == "debito")
                {
                    valorTotal = totalIva + (totalIva * pagoDebito);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Recargo por pago con {formaPago}: ${totalIva * pagoDebito}\n");

                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else if(formaPago == "credito")
                {
                    valorTotal = totalIva + (totalIva * pagoCredito);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Recargo por pago con {formaPago}: ${totalIva * pagoCredito}\n");

                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else if(formaPago == "efectivo")
                {
                    valorTotal = totalIva - (totalIva * pagoEfectivo);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Descuento por pago con {formaPago}: ${totalIva * pagoEfectivo}\n");


                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else
                {
                    Console.WriteLine("Forma de pago no reconocida.");

                }



            }
            else
            Console.WriteLine("El valor del producto no puede ser negativo.");
        }
        else
            Console.WriteLine("El valor del producto no puede ser negativo.");
        
        break;
    case "zapatillas":

        Console.WriteLine("Por favor ingres el valor del producto(ingresarlos sin . ni ,): ");
        valorUnit = int.Parse(Console.ReadLine());
        if (valorUnit >= 0){
            Console.WriteLine($"Por favor ingrese la cantidad del {nombreProducto} que desea comprar:");
            cantidad = int.Parse(Console.ReadLine());
            if(cantidad >= 0){
                subtotal = valorUnit * cantidad;
                double totalIva = subtotal+(subtotal*iva);
                Console.WriteLine("¿Que forma de pago?(debito,credito o efectivo): ");
                string formaPago = Console.ReadLine().ToLower();
                if(formaPago == "debito")
                {
                    valorTotal = totalIva + (totalIva * pagoDebito);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Recargo por pago con {formaPago}: ${totalIva * pagoDebito}\n");

                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else if(formaPago == "credito")
                {
                    valorTotal = totalIva + (totalIva * pagoCredito);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Recargo por pago con {formaPago}: ${totalIva * pagoCredito}\n");

                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else if(formaPago == "efectivo")
                {
                    valorTotal = totalIva - (totalIva * pagoEfectivo);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Descuento por pago con {formaPago}: ${totalIva * pagoEfectivo}\n");


                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else
                {
                    Console.WriteLine("Forma de pago no reconocida.");

                }



            }
            else
            Console.WriteLine("El valor del producto no puede ser negativo.");
        }
        else
            Console.WriteLine("El valor del producto no puede ser negativo.");

        break;
    case "gorra":
        Console.WriteLine("Por favor ingres el valor del producto(ingresarlos sin . ni ,): ");
        valorUnit = int.Parse(Console.ReadLine());
        if (valorUnit >= 0){
            Console.WriteLine($"Por favor ingrese la cantidad del {nombreProducto} que desea comprar:");
            cantidad = int.Parse(Console.ReadLine());
            if(cantidad >= 0){
                subtotal = valorUnit * cantidad;
                double totalIva = subtotal+(subtotal*iva);
                Console.WriteLine("¿Que forma de pago?(debito,credito o efectivo): ");
                string formaPago = Console.ReadLine().ToLower();
                if(formaPago == "debito")
                {
                    valorTotal = totalIva + (totalIva * pagoDebito);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Recargo por pago con {formaPago}: ${totalIva * pagoDebito}\n");

                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else if(formaPago == "credito")
                {
                    valorTotal = totalIva + (totalIva * pagoCredito);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Recargo por pago con {formaPago}: ${totalIva * pagoCredito}\n");

                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else if(formaPago == "efectivo")
                {
                    valorTotal = totalIva - (totalIva * pagoEfectivo);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Descuento por pago con {formaPago}: ${totalIva * pagoEfectivo}\n");


                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else
                {
                    Console.WriteLine("Forma de pago no reconocida.");

                }



            }
            else
            Console.WriteLine("El valor del producto no puede ser negativo.");
        }
        else
            Console.WriteLine("El valor del producto no puede ser negativo.");

        break;
    case "bufanda":
        Console.WriteLine("Por favor ingres el valor del producto(ingresarlos sin . ni ,): ");
        valorUnit = int.Parse(Console.ReadLine());
        if (valorUnit >= 0){
            Console.WriteLine($"Por favor ingrese la cantidad del {nombreProducto} que desea comprar:");
            cantidad = int.Parse(Console.ReadLine());
            if(cantidad >= 0){
                subtotal = valorUnit * cantidad;
                double totalIva = subtotal+(subtotal*iva);
                Console.WriteLine("¿Que forma de pago?(debito,credito o efectivo): ");
                string formaPago = Console.ReadLine().ToLower();
                if(formaPago == "debito")
                {
                    valorTotal = totalIva + (totalIva * pagoDebito);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Recargo por pago con {formaPago}: ${totalIva * pagoDebito}\n");

                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else if(formaPago == "credito")
                {
                    valorTotal = totalIva + (totalIva * pagoCredito);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Recargo por pago con {formaPago}: ${totalIva * pagoCredito}\n");

                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else if(formaPago == "efectivo")
                {
                    valorTotal = totalIva - (totalIva * pagoEfectivo);
                    Console.WriteLine($"Detalles de la compra:----------------------------");
                    Console.WriteLine($"Producto:  {nombreProducto}");
                    Console.WriteLine($"Valor:         ${valorUnit}");
                    Console.WriteLine($"Cantidad:       {cantidad}");
                    Console.WriteLine($"Subtotal:      ${subtotal}");
                    Console.WriteLine($"Forma de pago: {formaPago}");
                    Console.WriteLine($"IVA:    ,      ${subtotal * iva}");
                    Console.WriteLine($"Total IVA:     ${totalIva}");
                    Console.WriteLine($"Descuento por pago con {formaPago}: ${totalIva * pagoEfectivo}\n");


                    Console.WriteLine($"El total a pagar por {cantidad} {nombreProducto} es: ${valorTotal}");
                }
                else
                {
                    Console.WriteLine("Forma de pago no reconocida.");

                }



            }
            else
            Console.WriteLine("El valor del producto no puede ser negativo.");
        }
        else
            Console.WriteLine("El valor del producto no puede ser negativo.");

        break;

    default:
        Console.WriteLine("Producto no encontrado.");
        return; 
}



