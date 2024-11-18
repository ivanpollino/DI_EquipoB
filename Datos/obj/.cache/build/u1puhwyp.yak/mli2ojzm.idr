<!DOCTYPE html>
<!--[if IE]><![endif]-->
<html>
  
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <title>Class ActividadRepository
   </title>
    <meta name="viewport" content="width=device-width">
    <meta name="title" content="Class ActividadRepository
   ">
    <meta name="generator" content="docfx 2.59.4.0">
    
    <link rel="shortcut icon" href="../favicon.ico">
    <link rel="stylesheet" href="../styles/docfx.vendor.css">
    <link rel="stylesheet" href="../styles/docfx.css">
    <link rel="stylesheet" href="../styles/main.css">
    <meta property="docfx:navrel" content="../toc.html">
    <meta property="docfx:tocrel" content="toc.html">
    
    
    
  </head>
  <body data-spy="scroll" data-target="#affix" data-offset="120">
    <div id="wrapper">
      <header>
        
        <nav id="autocollapse" class="navbar navbar-inverse ng-scope" role="navigation">
          <div class="container">
            <div class="navbar-header">
              <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
              </button>
              
              <a class="navbar-brand" href="../index.html">
                <img id="logo" class="svg" src="../logo.svg" alt="">
              </a>
            </div>
            <div class="collapse navbar-collapse" id="navbar">
              <form class="navbar-form navbar-right" role="search" id="search">
                <div class="form-group">
                  <input type="text" class="form-control" id="search-query" placeholder="Search" autocomplete="off">
                </div>
              </form>
            </div>
          </div>
        </nav>
        
        <div class="subnav navbar navbar-default">
          <div class="container hide-when-search" id="breadcrumb">
            <ul class="breadcrumb">
              <li></li>
            </ul>
          </div>
        </div>
      </header>
      <div role="main" class="container body-content hide-when-search">
        
        <div class="sidenav hide-when-search">
          <a class="btn toc-toggle collapse" data-toggle="collapse" href="#sidetoggle" aria-expanded="false" aria-controls="sidetoggle">Show / Hide Table of Contents</a>
          <div class="sidetoggle collapse" id="sidetoggle">
            <div id="sidetoc"></div>
          </div>
        </div>
        <div class="article row grid-right">
          <div class="col-md-10">
            <article class="content wrap" id="_content" data-uid="Datos.Repositorys.ActividadRepository">
  
  
  <h1 id="Datos_Repositorys_ActividadRepository" data-uid="Datos.Repositorys.ActividadRepository" class="text-break">Class ActividadRepository
  </h1>
  <div class="markdown level0 summary"></div>
  <div class="markdown level0 conceptual"></div>
  <div class="inheritance">
    <h5>Inheritance</h5>
    <div class="level0"><span class="xref">System.Object</span></div>
    <div class="level1"><span class="xref">ActividadRepository</span></div>
  </div>
  <div class="inheritedMembers">
    <h5>Inherited Members</h5>
    <div>
      <span class="xref">System.Object.ToString()</span>
    </div>
    <div>
      <span class="xref">System.Object.Equals(System.Object)</span>
    </div>
    <div>
      <span class="xref">System.Object.Equals(System.Object, System.Object)</span>
    </div>
    <div>
      <span class="xref">System.Object.ReferenceEquals(System.Object, System.Object)</span>
    </div>
    <div>
      <span class="xref">System.Object.GetHashCode()</span>
    </div>
    <div>
      <span class="xref">System.Object.GetType()</span>
    </div>
    <div>
      <span class="xref">System.Object.MemberwiseClone()</span>
    </div>
  </div>
  <h6><strong>Namespace</strong>: <a class="xref" href="Datos.Repositorys.html">Datos.Repositorys</a></h6>
  <h6><strong>Assembly</strong>: Datos.dll</h6>
  <h5 id="Datos_Repositorys_ActividadRepository_syntax">Syntax</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public class ActividadRepository</code></pre>
  </div>
  <h3 id="methods">Methods
  </h3>
  
  
  <a id="Datos_Repositorys_ActividadRepository_bajaActividad_" data-uid="Datos.Repositorys.ActividadRepository.bajaActividad*"></a>
  <h4 id="Datos_Repositorys_ActividadRepository_bajaActividad_Datos_Infrastructure_Actividad_" data-uid="Datos.Repositorys.ActividadRepository.bajaActividad(Datos.Infrastructure.Actividad)">bajaActividad(Actividad)</h4>
  <div class="markdown level1 summary"><p>Elimina una actividad de la base de datos.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public string bajaActividad(Actividad actividad)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="Datos.Infrastructure.Actividad.html">Actividad</a></td>
        <td><span class="parametername">actividad</span></td>
        <td><p>La actividad que se desea eliminar.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.String</span></td>
        <td><p>Un mensaje de éxito indicando que la actividad ha sido eliminada correctamente.</p>
</td>
      </tr>
    </tbody>
  </table>
  
  
  <a id="Datos_Repositorys_ActividadRepository_GuardarActividad_" data-uid="Datos.Repositorys.ActividadRepository.GuardarActividad*"></a>
  <h4 id="Datos_Repositorys_ActividadRepository_GuardarActividad_Datos_Infrastructure_Actividad_" data-uid="Datos.Repositorys.ActividadRepository.GuardarActividad(Datos.Infrastructure.Actividad)">GuardarActividad(Actividad)</h4>
  <div class="markdown level1 summary"><p>Guarda una nueva actividad en la base de datos.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public void GuardarActividad(Actividad actividad)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="Datos.Infrastructure.Actividad.html">Actividad</a></td>
        <td><span class="parametername">actividad</span></td>
        <td><p>La actividad que se desea guardar.</p>
</td>
      </tr>
    </tbody>
  </table>
  
  
  <a id="Datos_Repositorys_ActividadRepository_listadoActividades_" data-uid="Datos.Repositorys.ActividadRepository.listadoActividades*"></a>
  <h4 id="Datos_Repositorys_ActividadRepository_listadoActividades" data-uid="Datos.Repositorys.ActividadRepository.listadoActividades">listadoActividades()</h4>
  <div class="markdown level1 summary"><p>Obtiene una lista de todas las actividades almacenadas en la base de datos.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public List&lt;Actividad&gt; listadoActividades()</code></pre>
  </div>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.Collections.Generic.List</span>&lt;<a class="xref" href="Datos.Infrastructure.Actividad.html">Actividad</a>&gt;</td>
        <td><p>Una lista con todas las actividades de la base de datos.</p>
</td>
      </tr>
    </tbody>
  </table>
  
  
  <a id="Datos_Repositorys_ActividadRepository_ObtenerMonitorPorDni_" data-uid="Datos.Repositorys.ActividadRepository.ObtenerMonitorPorDni*"></a>
  <h4 id="Datos_Repositorys_ActividadRepository_ObtenerMonitorPorDni_System_String_" data-uid="Datos.Repositorys.ActividadRepository.ObtenerMonitorPorDni(System.String)">ObtenerMonitorPorDni(String)</h4>
  <div class="markdown level1 summary"><p>Recupera un monitor de la base de datos utilizando su DNI.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public Monitor ObtenerMonitorPorDni(string dniMonitor)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.String</span></td>
        <td><span class="parametername">dniMonitor</span></td>
        <td><p>El DNI del monitor que se desea buscar.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="Datos.Infrastructure.Monitor.html">Monitor</a></td>
        <td><p>El monitor encontrado o null si no se encuentra ningún monitor con ese DNI.</p>
</td>
      </tr>
    </tbody>
  </table>
  
  
  <a id="Datos_Repositorys_ActividadRepository_ObtenerNuevoIdActividad_" data-uid="Datos.Repositorys.ActividadRepository.ObtenerNuevoIdActividad*"></a>
  <h4 id="Datos_Repositorys_ActividadRepository_ObtenerNuevoIdActividad" data-uid="Datos.Repositorys.ActividadRepository.ObtenerNuevoIdActividad">ObtenerNuevoIdActividad()</h4>
  <div class="markdown level1 summary"><p>Obtiene el próximo ID disponible para una nueva actividad, basado en el último ID utilizado.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public int ObtenerNuevoIdActividad()</code></pre>
  </div>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.Int32</span></td>
        <td><p>El siguiente ID disponible para una nueva actividad.</p>
</td>
      </tr>
    </tbody>
  </table>
  
  
  <a id="Datos_Repositorys_ActividadRepository_sacarActividad_" data-uid="Datos.Repositorys.ActividadRepository.sacarActividad*"></a>
  <h4 id="Datos_Repositorys_ActividadRepository_sacarActividad_Datos_Infrastructure_Actividad_" data-uid="Datos.Repositorys.ActividadRepository.sacarActividad(Datos.Infrastructure.Actividad)">sacarActividad(Actividad)</h4>
  <div class="markdown level1 summary"><p>Recupera una actividad de la base de datos a partir de su nombre.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public Actividad sacarActividad(Actividad actividad)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="Datos.Infrastructure.Actividad.html">Actividad</a></td>
        <td><span class="parametername">actividad</span></td>
        <td><p>La actividad que se desea buscar (por nombre).</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="Datos.Infrastructure.Actividad.html">Actividad</a></td>
        <td><p>La actividad encontrada en la base de datos, o un objeto vacío si no se encuentra ninguna coincidencia.</p>
</td>
      </tr>
    </tbody>
  </table>
</article>
          </div>
          
          <div class="hidden-sm col-md-2" role="complementary">
            <div class="sideaffix">
              <div class="contribution">
                <ul class="nav">
                </ul>
              </div>
              <nav class="bs-docs-sidebar hidden-print hidden-xs hidden-sm affix" id="affix">
                <h5>In This Article</h5>
                <div></div>
              </nav>
            </div>
          </div>
        </div>
      </div>
      
      <footer>
        <div class="grad-bottom"></div>
        <div class="footer">
          <div class="container">
            <span class="pull-right">
              <a href="#top">Back to top</a>
            </span>
            
            <span>Generated by <strong>DocFX</strong></span>
          </div>
        </div>
      </footer>
    </div>
    
    <script type="text/javascript" src="../styles/docfx.vendor.js"></script>
    <script type="text/javascript" src="../styles/docfx.js"></script>
    <script type="text/javascript" src="../styles/main.js"></script>
  </body>
</html>
