import 'package:flutter_modular/flutter_modular.dart';
import 'package:front/app/modules/dashboard/dashboard_page.dart';
import 'package:front/app/modules/despesas/cadastro_despesas_page.dart';
import 'package:front/app/modules/despesas/tipo_despesas_service.dart';
import 'package:front/app/modules/fornecedor/fornecedor_page.dart';
import 'package:front/app/modules/fornecedor/fornecedor_service.dart';
import 'package:front/app/modules/instituicao/instituicao_page.dart';
import 'package:front/app/modules/instituicao/instituicao_service.dart';
import 'package:front/app/modules/instituicao/tipo_instituicao_page.dart';
import 'package:front/app/modules/instituicao/tipo_instituicao_service.dart';
import 'package:front/app/modules/despesas/despesas_service.dart';
// import 'package:front/app/modules/despesas/tipo_despesas_service.dart';
import 'package:front/app/modules/home/home_page.dart';
import 'package:front/app/modules/login/login_page.dart';
import 'package:front/app/modules/login/tipo_usuario_service.dart';
import 'package:front/app/modules/login/usuario_login_service.dart';
import 'package:front/app/modules/login/usuario_service.dart';
import 'package:front/app/modules/orcamento/orcamento_page.dart';
import 'package:front/app/modules/orcamento/orcamento_service.dart';
// import 'package:front/app/modules/login/usuario_service.dart';
import 'package:front/app/modules/secretaria/secretaria_page.dart';
import 'package:front/app/modules/secretaria/secretaria_service.dart';
import 'package:front/app/modules/unidade/unidade_consumidora_page.dart';
import 'package:front/app/modules/unidade/unidade_consumidora_sevice.dart';
import 'package:front/app/modules/unidade/unidade_de_medida_page.dart';
import 'package:front/app/modules/unidade/unidade_de_medida_service.dart';
import 'package:front/app/providers/provider_theme.dart';
import '../modules/despesas/tipo_despesas_page.dart';
import '../modules/login/usuario_page.dart';

class AppModule extends Module {
  @override
  void binds(Injector i) {
    i.addLazySingleton(SecretariaServiceImpl.new);
    i.addLazySingleton(TipoDespesasServiceImpl.new);
    i.addLazySingleton(DespesasServiceImpl.new);
    i.addLazySingleton(TipoInstituicaoServiceImpl.new);
    i.addLazySingleton(InstituicaoServiceImpl.new);
    i.addLazySingleton(TipoUsuarioServiceImpl.new);
    i.addLazySingleton(UsuarioServiceImpl.new);
    i.addLazySingleton(UsuarioLoginServiceImpl.new);
    i.addLazySingleton(UnidadeMedidaServiceImpl.new);
    i.addLazySingleton(UnidadeConsumidoraServiceImpl.new);
    i.addLazySingleton(FornecedorServiceImpl.new);
    i.addLazySingleton(OrcamentoServiceImpl.new);
    i.addSingleton(ThemeApp.new);
    super.binds(i);
  }

  @override
  void routes(RouteManager r) {
    r.child('/', child: (_) => const HomePage());
    r.child('/instituicaoPage', child: (_) => const InstituicaoPage());
    r.child('/tipoInstituicaoPage', child: (_) => const TipoInstituicao());
    r.child('/tipoDeDespesas', child: (_) => const TipoDeDespesasPage());
    r.child('/despesas', child: (_) => const DesespesasPage());
    r.child('/unidadeDeMedida', child: (_) => const UnidadeDeMedidaPage());
    r.child('/orcamento', child: (_) => const OrcamentoPage());
    r.child('/unidadeConsumidora',
        child: (_) => const UnidadeConsumidoraPage());
    r.child('/usuarioPage', child: (_) => const UsuarioPage());
    r.child('/loginPage', child: (_) => const LoginPage());
    r.child('/secretariaPage', child: (_) => const SecretariaPage());
    super.routes(r);
    r.child('/fornecedorPage', child: (_) => const FornecedorPage());
    super.routes(r);
    r.child('/dasboardPage', child: (_) => const DashboardPage());
    super.routes(r);
  }
}
