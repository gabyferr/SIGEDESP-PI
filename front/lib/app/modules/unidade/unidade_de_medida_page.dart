import 'package:flutter/material.dart';
import 'package:flutter_modular/flutter_modular.dart';
import 'package:front/app/components/my_scaffold_comp.dart';
import 'package:front/app/modules/unidade/unidade_de_medida_model.dart';
import 'package:front/app/modules/unidade/unidade_de_medida_service.dart';
import 'package:result_dart/result_dart.dart';

class UnidadeDeMedidaPage extends StatefulWidget {
  const UnidadeDeMedidaPage({Key? key}) : super(key: key);

  @override
  State<UnidadeDeMedidaPage> createState() => _UnidadeDeMedidaPageState();
}

class _UnidadeDeMedidaPageState extends State<UnidadeDeMedidaPage> {
  late TextEditingController _controller;
  final service = Modular.get<UnidadeMedidaServiceImpl>();

  @override
  void initState() {
    _controller = TextEditingController();
    super.initState();
  }

  @override
  void dispose() {
    _controller.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return ScaffoldComp(
      body: Padding(
        padding:
            const EdgeInsets.all(16.0), // Ajuste o valor conforme necessário
        child: ListView(
          children: [
            const Padding(
              padding:
                  EdgeInsets.only(bottom: 30), // Ajuste conforme necessário
              child: Text(
                "Unidade de Medida",
                style: TextStyle(
                  fontSize: 30,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),
            Column(
              crossAxisAlignment: CrossAxisAlignment.stretch,
              children: [
                TextField(
                  decoration: const InputDecoration(
                    hintText: 'Buscar',
                    prefixIcon: Icon(Icons.search),
                    border: OutlineInputBorder(),
                  ),
                  controller: _controller,
                ),
                const SizedBox(height: 20), // Ajuste o espaçamento
                Row(
                  children: [
                    ElevatedButton(
                      onPressed: () async {
                        await modalCadastrar();
                      },
                      child: const Text('Cadastrar'),
                    ),
                    const SizedBox(width: 15),
                    const Text("Mostrar: "),
                    DropdownButton<String>(
                      borderRadius: BorderRadius.circular(10),
                      elevation: 10,
                      items: <String>['Opção 1', 'Opção 2', 'Opção 3']
                          .map((String value) {
                        return DropdownMenuItem<String>(
                          value: value,
                          child: Text(value),
                        );
                      }).toList(),
                      onChanged: (String? newValue) {},
                    ),
                  ],
                ),
                const SizedBox(height: 40), // Ajuste o espaçamento
              ],
            ),
            FutureBuilder(
              future: service.getAll().getOrNull(),
              builder: (context, AsyncSnapshot snapshot) {
                if (snapshot.connectionState == ConnectionState.none) {
                  return const Text("Sem internet");
                }

                if (snapshot.connectionState == ConnectionState.waiting) {
                  return const Center(
                    child: SizedBox(
                      width: 26,
                      height: 26,
                      child: CircularProgressIndicator(),
                    ),
                  );
                }

                if (snapshot.hasError) {
                  return const Text("Erro");
                }

                final List<UnidadeDeMedidaModel?> tp =
                    (snapshot.data ?? []).cast<UnidadeDeMedidaModel?>();

                return SizedBox(
                  height: 500,
                  width: double.infinity,
                  child: DataTable(
                    border: TableBorder.all(),
                    columns: const [
                      DataColumn(label: Text('Id')),
                      DataColumn(label: Text('Descrição')),
                      DataColumn(label: Text('Abreviatura')),
                      DataColumn(label: Text('Ações')),
                    ],
                    rows: tp.map((e) {
                      return DataRow(
                        cells: [
                          DataCell(Text(e?.id?.toString() ?? '')),
                          DataCell(Text(e?.descricao ?? '')),
                          DataCell(Text(e?.abreviatura ?? '')),
                          DataCell(Row(
                            children: [
                              IconButton(
                                icon: const Icon(
                                  Icons.edit,
                                  color: Color(0xFF0044FF),
                                ),
                                onPressed: () async {
                                  await modalCadastrar(e);
                                },
                              ),
                              IconButton(
                                icon: const Icon(
                                  Icons.delete,
                                  color: Color(0xFFF44336),
                                ),
                                onPressed: () async {
                                  await showDialog<bool>(
                                    context: context,
                                    builder: (BuildContext context) {
                                      return AlertDialog(
                                        title: const Text('Confirmar exclusão'),
                                        content: const Text(
                                            'Tem certeza que deseja excluir este item?'),
                                        actions: <Widget>[
                                          TextButton(
                                            child: const Text('Cancelar'),
                                            onPressed: () {
                                              Modular.to.pop(false);
                                            },
                                          ),
                                          TextButton(
                                            child: const Text('Confirmar'),
                                            onPressed: () async {
                                              Modular.to.pop();
                                              if (e?.id != null) {
                                                await service
                                                    .deleteData(e!.id!);
                                                setState(() {});
                                              }
                                            },
                                          ),
                                        ],
                                      );
                                    },
                                  );
                                },
                              ),
                            ],
                          )),
                        ],
                      );
                    }).toList(),
                  ),
                );
              },
            ),
          ],
        ),
      ),
    );
  }

  Future<void> modalCadastrar([UnidadeDeMedidaModel? unidadeDeMedida]) async {
    bool isEdit = unidadeDeMedida?.id != null;
    final unidadeDeMedidaDescEditCtrl =
        TextEditingController(text: unidadeDeMedida?.descricao ?? '');
    final unidadeDeMedidaAbreviaturaEditCtrl =
        TextEditingController(text: unidadeDeMedida?.abreviatura ?? '');

    await showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('${isEdit ? 'Editar' : 'Cadastro de'} Unidade de Medida'),
          content: Wrap(
            children: [
              TextField(
                controller: unidadeDeMedidaDescEditCtrl,
                decoration: const InputDecoration(
                  labelText: 'Nome',
                ),
              ),
              TextField(
                controller: unidadeDeMedidaAbreviaturaEditCtrl,
                decoration: const InputDecoration(
                  labelText: 'Abreviatura',
                ),
              ),
            ],
          ),
          actions: <Widget>[
            TextButton(
              child: const Text('Cancelar'),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
            TextButton(
              child: const Text('Salvar'),
              onPressed: () async {
                if (isEdit) {
                  final resp = await service.editData(
                    unidadeDeMedida!.copyWith(
                      descricao: unidadeDeMedidaDescEditCtrl.text,
                      abreviatura: unidadeDeMedidaAbreviaturaEditCtrl.text,
                    ),
                  );
                  resp.fold((success) {
                    Navigator.of(context).pop();
                    setState(() {});
                  }, (failure) {
                    print('Erro: $failure');
                  });
                } else {
                  final resp = await service.postData(
                    UnidadeDeMedidaModel(
                      descricao: unidadeDeMedidaDescEditCtrl.text,
                      abreviatura: unidadeDeMedidaAbreviaturaEditCtrl.text,
                    ),
                  );
                  resp.fold((success) {
                    Navigator.of(context).pop();
                    setState(() {});
                  }, (failure) {
                    print('Erro: $failure');
                  });
                }
              },
            ),
          ],
        );
      },
    );
    unidadeDeMedidaDescEditCtrl.dispose();
    unidadeDeMedidaAbreviaturaEditCtrl.dispose();
  }
}
