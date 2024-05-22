import 'package:flutter/material.dart';
import 'package:flutter_modular/flutter_modular.dart';
import 'package:front/app/components/Scaffold_comp.dart';
import 'package:front/app/modules/Instituicao/instituicao_model.dart';
import 'package:front/app/modules/Instituicao/instituicao_service.dart';
import 'package:result_dart/result_dart.dart';

class InstituicaoPage extends StatefulWidget {
  const InstituicaoPage({Key? key}) : super(key: key);

  @override
  State<InstituicaoPage> createState() => _InstituicaoPageState();
}

class _InstituicaoPageState extends State<InstituicaoPage> {
  late TextEditingController _instituicao;
  late TextEditingController _controller;
  String _currentTipoDespesa = '';
  final service = Modular.get<InstituicaoServiceImpl>();

  @override
  void initState() {
    _controller = TextEditingController();
    _instituicao = TextEditingController();
    super.initState();
  }

  @override
  void dispose() {
    _controller.dispose();
    _instituicao.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return ScaffoldComp(
        body: Padding(
            padding: const EdgeInsets.all(16.0),
            child: ListView(
              children: [
                const Padding(
                  padding: EdgeInsets.only(bottom: 50),
                  child: Text(
                    "Cadastro de Instituição",
                    style: TextStyle(
                      fontSize: 30,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                ),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.stretch,
                  children: [
                    ElevatedButton(
                      onPressed: () async {
                        await modalCadastrar();
                      },
                      child: const Text('Cadastrar Nova Instituição'),
                    ),
                    const SizedBox(height: 30),
                    Row(
                      children: [
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
                        const SizedBox(
                          width: 20,
                        ),
                        const Expanded(
                          child: TextField(
                            decoration: InputDecoration(
                              hintText: 'Buscar Instituição',
                              prefixIcon: Icon(Icons.search),
                              border: OutlineInputBorder(),
                            ),
                          ),
                        ),
                      ],
                    ),
                  ],
                ),
                Padding(
                  padding: const EdgeInsets.only(top: 60),
                  child: FutureBuilder(
                    future: service.getAll().getOrNull(),
                    builder: (context, AsyncSnapshot snapshot) {
                      if (snapshot.connectionState == ConnectionState.none) {
                        return const Text("sem internet");
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

                      final tp =
                          (snapshot.data ?? []).cast<InstituicaoModel?>();

                      return DataTable(
                        border: TableBorder.all(),
                        columns: const [DataColumn(label: Text('Descrição'))],
                        rows: tp.map((e) {
                          return DataRow(cells: [
                            DataCell(
                              Row(
                                children: [
                                  Expanded(child: Text(e?.tipoDespesa ?? '')),
                                  IconButton(
                                    icon: const Icon(Icons.edit),
                                    onPressed: () async {
                                      final newText = await showDialog<String>(
                                        context: context,
                                        builder: (BuildContext context) {
                                          return AlertDialog(
                                            title: const Text('Editar Instituição'),
                                            content: TextField(
                                              controller: TextEditingController(
                                                  text: _currentTipoDespesa),
                                              onChanged: (value) {
                                                _currentTipoDespesa = value;
                                              },
                                            ),
                                            actions: <Widget>[
                                              TextButton(
                                                onPressed: () {
                                                  Navigator.of(context)
                                                      .pop(_currentTipoDespesa);
                                                },
                                                child: const Text('Salvar'),
                                              ),
                                            ],
                                          );
                                        },
                                      );
                                      if (newText != null) {
                                        final resp = await service.editData(
                                          e.id,
                                          InstituicaoModel(
                                            situacao: newText,
                                          ).toJson(),
                                        );
                                        setState(() {});
                                      }
                                    },
                                  ),
                                  IconButton(
                                    icon: const Icon(Icons.delete),
                                    onPressed: () async {
                                      final confirmDelete =
                                          await showDialog<bool>(
                                        context: context,
                                        builder: (BuildContext context) {
                                          return AlertDialog(
                                            title: const Text(
                                                'Confirmar exclusão'),
                                            content: const Text(
                                                'Tem certeza que deseja excluir este item?'),
                                            actions: <Widget>[
                                              TextButton(
                                                onPressed: () {
                                                  Modular.to.pop(false);
                                                },
                                                child: const Text('Cancelar'),
                                              ),
                                              TextButton(
                                                onPressed: () {
                                                  Modular.to.pop(true);
                                                },
                                                child: const Text('Confirmar'),
                                              ),
                                            ],
                                          );
                                        },
                                      );
                                      if (confirmDelete == true) {}
                                    },
                                  ),
                                ],
                              ),
                            ),
                          ]);
                        }).toList(),
                      );
                    },
                  ),
                )
              ],
            )));
  }

  Future<void> modalCadastrar() async {
    await showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Cadastro de Instituição'),
          content: TextField(
            controller: _instituicao,
            decoration: const InputDecoration(
              hintText: 'Situação da Instituição',
            ),
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
                //tela load
                final resp = await service.postData(InstituicaoModel(
                  situacao: _instituicao.text,
                ).toJson());
                resp.fold((success) {
                  Navigator.of(context).pop();
                  setState(() {});
                }, (failure) {
                  //snack bar
                  print('erro');
                });
              },
            ),
          ],
        );
      },
    );
    _instituicao.dispose();
  }
}
