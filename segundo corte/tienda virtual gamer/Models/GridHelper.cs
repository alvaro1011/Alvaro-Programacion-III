using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tienda_virtual_gamer.Models
{
    public static class GridHelper
    {
        // ─────────────────────────────────────────
        // ESTILO BASE — aplica a cualquier grid
        // ─────────────────────────────────────────
        public static void AplicarEstilo(DataGridView grid)
        {
            Color fondo = Color.FromArgb(15, 52, 67);
            Color fondoAlt = Color.FromArgb(5, 32, 41);
            Font fuente = new Font("Segoe UI", 9.5f);

            grid.AllowUserToAddRows = false;
            grid.ReadOnly = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeight = 35;
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor = fondoAlt;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);

            grid.DefaultCellStyle.BackColor = fondo;
            grid.DefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.Font = fuente;
            grid.DefaultCellStyle.SelectionBackColor = fondo;
            grid.DefaultCellStyle.SelectionForeColor = Color.White;

            grid.AlternatingRowsDefaultCellStyle.BackColor = fondoAlt;
            grid.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            grid.AlternatingRowsDefaultCellStyle.Font = fuente;
        }

        // ─────────────────────────────────────────
        // CARGAR PRODUCTOS
        // ─────────────────────────────────────────
        public static void CargarTablaProductos(DataGridView grid, List<Producto> productos)
        {
            Limpiar(grid);

            grid.Columns.Add("Codigo", "Código");
            grid.Columns.Add("Nombre", "Nombre");
            grid.Columns.Add("Categoria", "Categoría");
            grid.Columns.Add("Precio", "Precio");
            grid.Columns.Add("Cantidad", "Cantidad");

            AplicarEstilo(grid);

            Color fondo = Color.FromArgb(15, 52, 67);
            Color fondoAlt = Color.FromArgb(5, 32, 41);

            foreach (Producto p in productos)
            {
                int fila = grid.Rows.Add(p.Codigo, p.Nombre, p.Categoria, $"${p.Precio}", p.Cantidad);

                // Resaltar stock bajo en rojo
                if (p.Cantidad <= 5)
                {
                    grid.Rows[fila].Cells["Cantidad"].Style.ForeColor = Color.OrangeRed;
                    grid.Rows[fila].Cells["Cantidad"].Style.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                }

                grid.Rows[fila].DefaultCellStyle.BackColor = fila % 2 == 0 ? fondo : fondoAlt;
            }

            Finalizar(grid);
        }

        // ─────────────────────────────────────────
        // CARGAR ENTRADAS
        // ─────────────────────────────────────────
        public static void CargarTablaEntradas(DataGridView grid, List<string[]> entradas)
        {
            Limpiar(grid);

            grid.Columns.Add("Fecha", "Fecha");
            grid.Columns.Add("Codigo", "Código");
            grid.Columns.Add("Nombre", "Nombre");
            grid.Columns.Add("Cantidad", "Cantidad");
            grid.Columns.Add("Observacion", "Observación");

            AplicarEstilo(grid);

            Color fondo = Color.FromArgb(15, 52, 67);
            Color fondoAlt = Color.FromArgb(5, 32, 41);

            foreach (string[] datos in entradas)
            {
                if (datos.Length < 5) continue;

                int fila = grid.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);

                grid.Rows[fila].Cells["Cantidad"].Style.ForeColor = Color.MediumSeaGreen;
                grid.Rows[fila].Cells["Cantidad"].Style.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                grid.Rows[fila].DefaultCellStyle.BackColor = fila % 2 == 0 ? fondo : fondoAlt;
            }

            Finalizar(grid);
        }

        // ─────────────────────────────────────────
        // CARGAR SALIDAS
        // ─────────────────────────────────────────
        public static void CargarTablaSalidas(DataGridView grid, List<string[]> salidas)
        {
            Limpiar(grid);

            grid.Columns.Add("Fecha", "Fecha");
            grid.Columns.Add("Codigo", "Código");
            grid.Columns.Add("Nombre", "Nombre");
            grid.Columns.Add("Cantidad", "Cantidad");
            grid.Columns.Add("Observacion", "Observación");

            AplicarEstilo(grid);

            Color fondo = Color.FromArgb(15, 52, 67);
            Color fondoAlt = Color.FromArgb(5, 32, 41);

            foreach (string[] datos in salidas)
            {
                if (datos.Length < 5) continue;

                int fila = grid.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);

                grid.Rows[fila].Cells["Cantidad"].Style.ForeColor = Color.OrangeRed;
                grid.Rows[fila].Cells["Cantidad"].Style.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                grid.Rows[fila].DefaultCellStyle.BackColor = fila % 2 == 0 ? fondo : fondoAlt;
            }

            Finalizar(grid);
        }

        // ─────────────────────────────────────────
        // CARGAR MOVIMIENTOS (entradas + salidas mezcladas)
        // ─────────────────────────────────────────
        public static void CargarTablaMovimientos(DataGridView grid,
            List<string[]> entradas, List<string[]> salidas)
        {
            Limpiar(grid);

            grid.Columns.Add("Fecha", "Fecha");
            grid.Columns.Add("Tipo", "Tipo");
            grid.Columns.Add("Codigo", "Código");
            grid.Columns.Add("Nombre", "Producto");
            grid.Columns.Add("Cantidad", "Cantidad");

            AplicarEstilo(grid);

            Color fondo = Color.FromArgb(15, 52, 67);
            Color fondoAlt = Color.FromArgb(5, 32, 41);

            foreach (string[] datos in entradas)
            {
                if (datos.Length < 5) continue;

                int fila = grid.Rows.Add(datos[0], "▲ Entrada", datos[1], datos[2], datos[3]);

                grid.Rows[fila].Cells["Tipo"].Style.ForeColor = Color.MediumSeaGreen;
                grid.Rows[fila].Cells["Tipo"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                grid.Rows[fila].Cells["Cantidad"].Style.ForeColor = Color.MediumSeaGreen;
                grid.Rows[fila].Cells["Cantidad"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                grid.Rows[fila].DefaultCellStyle.BackColor = fila % 2 == 0 ? fondo : fondoAlt;
            }

            foreach (string[] datos in salidas)
            {
                if (datos.Length < 5) continue;

                int fila = grid.Rows.Add(datos[0], "▼ Salida", datos[1], datos[2], datos[3]);

                grid.Rows[fila].Cells["Tipo"].Style.ForeColor = Color.OrangeRed;
                grid.Rows[fila].Cells["Tipo"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                grid.Rows[fila].Cells["Cantidad"].Style.ForeColor = Color.OrangeRed;
                grid.Rows[fila].Cells["Cantidad"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                grid.Rows[fila].DefaultCellStyle.BackColor = fila % 2 == 0 ? fondo : fondoAlt;
            }

            Finalizar(grid);
        }

        // ─────────────────────────────────────────
        // UTILIDADES PRIVADAS
        // ─────────────────────────────────────────
        private static void Limpiar(DataGridView grid)
        {
            grid.DataSource = null;
            grid.Rows.Clear();
            grid.Columns.Clear();
        }

        private static void Finalizar(DataGridView grid)
        {
            grid.ClearSelection();
            grid.CurrentCell = null;
        }

        // ─────────────────────────────────────────
        // CARGAR MOVIMIENTOS CON FILTRO
        // ─────────────────────────────────────────
        public static void CargarTablaMovimientos(DataGridView grid,
            List<string[]> entradas, List<string[]> salidas, string filtroCodigo = null)
        {
            Limpiar(grid);

            grid.Columns.Add("Fecha", "Fecha");
            grid.Columns.Add("Tipo", "Tipo");
            grid.Columns.Add("Codigo", "Código");
            grid.Columns.Add("Nombre", "Producto");
            grid.Columns.Add("Cantidad", "Cantidad");

            AplicarEstilo(grid);

            Color fondo = Color.FromArgb(15, 52, 67);
            Color fondoAlt = Color.FromArgb(5, 32, 41);

            foreach (string[] datos in entradas)
            {
                if (datos.Length < 5) continue;
                if (filtroCodigo != null && datos[1].Trim() != filtroCodigo) continue;

                int fila = grid.Rows.Add(datos[0], "▲ Entrada", datos[1], datos[2], datos[3]);
                grid.Rows[fila].Cells["Tipo"].Style.ForeColor = Color.MediumSeaGreen;
                grid.Rows[fila].Cells["Tipo"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                grid.Rows[fila].Cells["Cantidad"].Style.ForeColor = Color.MediumSeaGreen;
                grid.Rows[fila].Cells["Cantidad"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                grid.Rows[fila].DefaultCellStyle.BackColor = fila % 2 == 0 ? fondo : fondoAlt;
            }

            foreach (string[] datos in salidas)
            {
                if (datos.Length < 5) continue;
                if (filtroCodigo != null && datos[1].Trim() != filtroCodigo) continue;

                int fila = grid.Rows.Add(datos[0], "▼ Salida", datos[1], datos[2], datos[3]);
                grid.Rows[fila].Cells["Tipo"].Style.ForeColor = Color.OrangeRed;
                grid.Rows[fila].Cells["Tipo"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                grid.Rows[fila].Cells["Cantidad"].Style.ForeColor = Color.OrangeRed;
                grid.Rows[fila].Cells["Cantidad"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                grid.Rows[fila].DefaultCellStyle.BackColor = fila % 2 == 0 ? fondo : fondoAlt;
            }

            Finalizar(grid);
        }

        // ─────────────────────────────────────────
        // CARGAR STOCK ACTUAL POR PRODUCTO
        // ─────────────────────────────────────────
        public static void CargarTablaStock(DataGridView grid,
            List<Producto> productos, List<string[]> entradas, List<string[]> salidas)
        {
            Limpiar(grid);

            grid.Columns.Add("Codigo", "Código");
            grid.Columns.Add("Nombre", "Nombre");
            grid.Columns.Add("StockIni", "Stock Ini.");
            grid.Columns.Add("Entradas", "+ Entradas");
            grid.Columns.Add("Salidas", "– Salidas");
            grid.Columns.Add("StockAct", "Stock Actual");

            AplicarEstilo(grid);

            Color fondo = Color.FromArgb(15, 52, 67);
            Color fondoAlt = Color.FromArgb(5, 32, 41);

            foreach (var p in productos)
            {
                int totalE = 0, totalS = 0;

                foreach (string[] e in entradas)
                    if (e.Length >= 4 && e[1].Trim() == p.Codigo &&
                        int.TryParse(e[3].Replace("+", ""), out int ce))
                        totalE += ce;

                foreach (string[] s in salidas)
                    if (s.Length >= 4 && s[1].Trim() == p.Codigo &&
                        int.TryParse(s[3].Replace("-", ""), out int cs))
                        totalS += cs;

                int stockActual = p.Cantidad + totalE - totalS;

                int fila = grid.Rows.Add(p.Codigo, p.Nombre, p.Cantidad, $"+{totalE}", $"-{totalS}", stockActual);

                grid.Rows[fila].Cells["Entradas"].Style.ForeColor = totalE > 0 ? Color.MediumSeaGreen : Color.Gray;
                grid.Rows[fila].Cells["Entradas"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);

                grid.Rows[fila].Cells["Salidas"].Style.ForeColor = totalS > 0 ? Color.OrangeRed : Color.Gray;
                grid.Rows[fila].Cells["Salidas"].Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);

                grid.Rows[fila].Cells["StockAct"].Style.ForeColor = stockActual <= 5 ? Color.OrangeRed : Color.MediumSeaGreen;
                grid.Rows[fila].Cells["StockAct"].Style.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

                grid.Rows[fila].DefaultCellStyle.BackColor = fila % 2 == 0 ? fondo : fondoAlt;
            }

            Finalizar(grid);
        }
    }
}