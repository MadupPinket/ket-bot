namespace KetBot.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KetBot.Data.Models.KetBotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KetBot.Data.Models.KetBotContext context)
        {
            // -----------------------------------------------------------
            context.SelectiveForms.AddOrUpdate(p => p.Code,
                new SelectiveForm
                {
                    Code = "0",
                    Form = string.Join("\n", new string[]
                    {
                        "����Ʈ ����",
                        "����Ʈ ���",
                        "���� ����Ʈ ����",
                        "�����",
                        "����",
                        "���׽Ű�",
                        "��Ÿ"
                    })
                },
                new SelectiveForm
                {
                    Code = "1",
                    Form = string.Join("\n", new string[]
                    {
                        "����Ʈ ���� ����",
                        "����Ʈ ���� ���",
                        "����Ʈ ���� ��Ÿ",
                        "����Ʈ �Ҹ�"
                    })
                },
                new SelectiveForm
                {
                    Code = "2",
                    Form = string.Join("\n", new string[]
                    {
                        "����Ʈ ���"
                    })
                },
                new SelectiveForm
                {
                    Code = "3",
                    Form = string.Join("\n", new string[]
                    {
                        "�ٷ�����",
                        "���ȭ�� ����Ʈ"
                    })
                },
                new SelectiveForm
                {
                    Code = "4",
                    Form = string.Join("\n", new string[]
                    {
                        "��� ����"
                    })
                },
                new SelectiveForm
                {
                    Code = "5",
                    Form = string.Join("\n", new string[]
                    {
                        "�̿� ����",
                        "��ǰ��"
                    })
                },
                new SelectiveForm
                {
                    Code = "6",
                    Form = string.Join("\n", new string[]
                    {
                        "ȭ�� ����"
                    })
                },
                new SelectiveForm
                {
                    Code = "7",
                    Form = string.Join("\n", new string[]
                    {
                        "���ǻ���",
                        "���� ����",
                        "Ŭ���̾�Ʈ ����",
                        "�̿� ����",
                        "��Ÿ"
                    })
                },
                new SelectiveForm
                {
                    Code = "8",
                    Form = string.Join("\n", new string[]
                    {
                        "ȭ�� ����"
                    })
                },
                new SelectiveForm
                {
                    Code = "11",
                    Form = string.Join("\n", new string[]
                    {
                        "��ȯ��ư Ŭ�� �� ������ �����.",
                        "�������� �������� ������ �־��.",
                        "���ȹ��� �Է� �������� ������ �־��.",
                        "����Ʈ ������ �ߴµ� �״�ο���."
                    })
                },
                new SelectiveForm
                {
                    Code = "12",
                    Form = string.Join("\n", new string[]
                    {
                        "�Ǽ��� ����Ʈ ������ �ع��Ⱦ��.",
                        "����Ʈ ������ ������ּ���."
                    })
                },
                new SelectiveForm
                {
                    Code = "13",
                    Form = string.Join("\n", new string[]
                    {
                        "�ٸ� ī��� ����Ʈ�� �����ϰ� �;��.",
                        "������ ����Ʈ�� �ٸ� ī���� �Ű� �ּ���."
                    })
                },
                new SelectiveForm
                {
                    Code = "14",
                    Form = string.Join("\n", new string[]
                    {
                        "Ż���ߴ��� ����Ʈ�� ��������.",
                        "����Ʈ�� ��������."
                    })
                },
                new SelectiveForm
                {
                    Code = "21",
                    Form = string.Join("\n", new string[]
                    {
                        "����Ʈ ������ �˰�;��."
                    })
                },
                new SelectiveForm
                {
                    Code = "31",
                    Form = string.Join("\n", new string[]
                    {
                        "������ �ȵƾ��."
                    })
                },
                new SelectiveForm
                {
                    Code = "32",
                    Form = string.Join("\n", new string[]
                    {
                        "���� ����Ʈ ���� �ʹ� �����."
                    })
                },
                new SelectiveForm
                {
                    Code = "41",
                    Form = string.Join("\n", new string[]
                    {
                        "����� ī�带 �ڵ����� ����ϰ� �;��.",
                        "�ſ�ī�带 ����ϰ� �;��.",
                        "���ڵ尡 ���µ� ��� ����� �˰� �;��.",
                        "����� ����Ʈ�� ��ȸ�ϰ� �;��."
                    })
                },
                new SelectiveForm
                {
                    Code = "51",
                    Form = string.Join("\n", new string[]
                    {
                        "��ǰ ��� ����� �˰�;��.",
                        "��� ������ Ȯ���ϰ� �;��.",
                        "�ٸ� ��ǰ���� ��ȯ�ϰ� �;��.",
                        "���� ���� ���� ������ ����ϰ� �;��.",
                        "���ǸӴ� ��ǰ�� ������ �˷��ּ���."
                    })
                },
                new SelectiveForm
                {
                    Code = "52",
                    Form = string.Join("\n", new string[]
                    {
                        "��ǰ�� ��� ����� �˰�;��.",
                        "��ǰ�� ������ ��� �ϳ���?",
                        "��ǰ�� ������ �������Ⱦ��.",
                        "����� ��ǰ�� ��� �ܾ��� �˷��ּ���."
                    })
                },
                new SelectiveForm
                {
                    Code = "61",
                    Form = string.Join("\n", new string[]
                    {
                        "ȭ���� ������.",
                        "���ȭ�� ���� �� ����Ʈ�� ������ �ʾƿ�."
                    })
                },
                new SelectiveForm
                {
                    Code = "71",
                    Form = string.Join("\n", new string[]
                    {
                        "���ǻ����� �ִµ���."
                    })
                },
                new SelectiveForm
                {
                    Code = "72",
                    Form = string.Join("\n", new string[]
                    {
                        "Ż���ϴ� ����� �˰�;��.",
                        "��ȣ/��⸦ �����ϰ� ������ ����;��."
                    })
                },
                new SelectiveForm
                {
                    Code = "73",
                    Form = string.Join("\n", new string[]
                    {
                        "�缳ġ �� ���� ���� ����Ʈ�� ��� �� �� �ֳ���?"
                    })
                },
                new SelectiveForm
                {
                    Code = "74",
                    Form = string.Join("\n", new string[]
                    {
                        "�α��� �ϰ�;��.",
                        "�α׾ƿ� �ϰ�;��.",
                        "���̵�(��й�ȣ)�� �˷��ּ���.",
                        "���̵� ������ �ϰ�;��.",
                        "��й�ȣ�� �����ϰ�;��.",
                        "�̸��� �ٲٰ� �;��.",
                        "���ȭ���� �����ϰ�;��.",
                        "���ȭ�� ����Ʈ ���� �ֱ⸦ �˰�;��.",
                        "������ �������ּ���."
                    })
                },
                new SelectiveForm
                {
                    Code = "75",
                    Form = string.Join("\n", new string[]
                    {
                        "�����͸� �˷��ּ���."
                    })
                }
            );

            // -----------------------------------------------------------

            //context.ExecutiveQuestions.AddOrUpdate(p => p.Code,
            //    new ExecutiveQuestion
            //    {
            //        Code = "111",
            //        Keyword = "����Ʈ ��ȯ",
            //        Question = "��ȯ��ư Ŭ�� �� ������ �����.",
            //        Answers = new System.Collections.Generic.List<Answer>()
            //        {
            //             new Answer
            //            {
            //                Order = 10,
            //                QuestionId = 1,
            //                Text = "�����Ͻ� ������ �ֽ� �� �������� ��ġ�� ����Ǿ����ϴ�. ���� ������ �õ��غ�����. :]"
            //            },
            //            new Answer
            //            {
            //                Order = 20,
            //                QuestionId = 1,
            //                Text = "1. ������ ��ġ�� �� ����\n 2. ���� �÷��� ������ �ֽ� �������� �缳ġ"
            //            },
            //            new Answer
            //            {
            //                Order = 30,
            //                QuestionId = 1,
            //                Text = "���Ŀ��� ������ ������ �߻��Ѵٸ�, �Ŵ������� ������ּ���!!"
            //            }
            //        }
            //    },
            //    new ExecutiveQuestion
            //    {
            //        Code = "112",
            //        Keyword = "��������",
            //        Question = "�������� �������� ������ �־��.",
            //        Answers = new System.Collections.Generic.List<Answer>()
            //        {
            //             new Answer
            //            {
            //                Order = 10,
            //                QuestionId = 1,
            //                Text = "�����Ͻ� ������ �ֽ� �� �������� ��ġ�� ����Ǿ����ϴ�. ���� ������ �õ��غ�����. :]"
            //            },
            //            new Answer
            //            {
            //                Order = 20,
            //                QuestionId = 1,
            //                Text = "1. ������ ��ġ�� �� ���� 2. ���� �÷��� ������ �ֽ� �������� �缳ġ"
            //            },
            //            new Answer
            //            {
            //                Order = 30,
            //                QuestionId = 1,
            //                Text = "���Ŀ��� ������ ������ �߻��Ѵٸ�, �Ŵ������� ������ּ���!!"
            //            }
            //        }
            //    }

            //);

            ////// -----------------------------------------------------------

            //context.CommentDefinitions.AddOrUpdate(p => p.Code,
            //    new CommentDefinition
            //    {
            //        Catetory = "Greetings",
            //        Code = "RGB01",
            //        Definition = "�⺻ �λ�",
            //        Owner = "Bot",
            //        Comments = new System.Collections.Generic.List<Comment>()
            //        {
            //            new Comment
            //            {
            //                Text = "�ȳ��ϼ���! :]"
            //            },
            //            new Comment
            //            {
            //                Text = "��! �θ��̳���, ȸ����?"
            //            },
            //            new Comment
            //            {
            //                Text = "���� ã���̴ٰ� ������."
            //            }
            //        }
            //    }
            //    //,
            //    //new CommentDefinition
            //    //{
            //    //    Catetory = "",
            //    //    Code = "",
            //    //    Definition = "",
            //    //    Owner = "",
            //    //    Comments = new System.Collections.Generic.List<Comment>()
            //    //    {
            //    //        new Comment
            //    //        {
            //    //            Text = ""
            //    //        },
            //    //        new Comment
            //    //        {
            //    //            Text = ""
            //    //        },
            //    //        new Comment
            //    //        {
            //    //            Text = ""
            //    //        }
            //    //    }
            //    //}
            //);

            //// -----------------------------------------------------------

            // -----------------------------------------------------------

            context.ExecutiveQuestions.AddOrUpdate(p => p.Code,
                new ExecutiveQuestion
                {
                    Code = "111",
                    Keyword = "����Ʈ ��ȯ",
                    Question = "��ȯ��ư Ŭ�� �� ������ �����.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�����Ͻ� ������ �ֽ� �� �������� ��ġ�� ����Ǿ����ϴ�. ���� ������ �õ��غ�����. :]"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "1. ������ ��ġ�� �� ����\n 2. ���� �÷��� ������ �ֽ� �������� �缳ġ"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "���Ŀ��� ������ ������ �߻��Ѵٸ�, �Ŵ������� ������ּ���!!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "112",
                    Keyword = "��������",
                    Question = "�������� �������� ������ �־��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�����Ͻ� ������ �ֽ� �� �������� ��ġ�� ����Ǿ����ϴ�. ���� ������ �õ��غ�����. :]"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "1. ������ ��ġ�� �� ���� 2. ���� �÷��� ������ �ֽ� �������� �缳ġ"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "���Ŀ��� ������ ������ �߻��Ѵٸ�, �Ŵ������� ������ּ���!!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "113",
                    Keyword = "���ȹ���",
                    Question = "���ȹ��� �Է� �������� ������ �־��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�����Ͻ� ������ �ֽ� �� �������� ��ġ�� ����Ǿ����ϴ�. ���� ������ �õ��غ�����. :]"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "1. ������ ��ġ�� �� ���� 2. ���� �÷��� ������ �ֽ� �������� �缳ġ"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "���Ŀ��� ������ ������ �߻��Ѵٸ�, �Ŵ������� ������ּ���!!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "114",
                    Keyword = "��ü/���� ����",
                    Question = "����Ʈ ������ �ߴµ� �״�ο���.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�����Ͻ� ������ ���� �� ���� ������ �־��."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "1. �����Ͻ÷��� �����翡 ��ü����� �ְų� �����Ͻ� ��� 2. �����Ͻ÷��� �׼��� �����翡�� ���� �׼����� �۰ų� ū ���"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "1���� ���, �ش� ī���� ���� ������ ������. 2���� ��쿡�� �����縶�� �ٸ����� ���� �� ���� 100�� Ȥ�� 500�� �̻�, 50���� ���ϸ� ���� �����ϴ�ϴ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "121",
                    Keyword = "������",
                    Question = "�Ǽ��� ����Ʈ ������ �ع��Ⱦ��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�̷�!! ���� ���̰ڳ׿�. ������ ���� ������!!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�Է�â�� ���ؼ� �Ŵ����Կ��� ����� �ذ��� �ֽ� �� �־��."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "���� ����ó�� �Ⱓ�� ���� 2~3�������� �ɸ��ٰ� �ϳ׿�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "122",
                    Keyword = "�ܼ����",
                    Question = "����Ʈ ������ ������ּ���.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = " ����Ʈ ���� ��Ҵ�, �Է�â�� ���ؼ� �Ŵ����Կ��� ���� ��û�ϼž� �Ѵ�ϴ�.]"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�� ���� �������� �Ŵ����Բ� ��Ȳ�� �����帮�� �ذ����ֽǲ�����!"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "���� ����ó�� �Ⱓ�� ���� 2~3�������� �ɸ��ٰ� �ϳ׿�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "131",
                    Keyword = "����ó �� ī���",
                    Question = "�ٸ� ī��� ����Ʈ�� �����ϰ� �;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�ƽ��Ե�, ���޸���Ʈ�� ���� ī���� ���� �����Ͻ� �� �����. �Ф�"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "���� �� ���� ���� �������̴�, �� �����Ҳ�����!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "132",
                    Keyword = "������",
                    Question = "������ ����Ʈ�� �ٸ� ī���� �Ű� �ּ���.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "ī��縶�� ����� �ٸ��� ������, ������ ����Ʈ�� �ٸ� ī���� �ű� ���� �����."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "141",
                    Keyword = "Ż��ȸ��",
                    Question = "Ż���ߴ��� ����Ʈ�� ��������.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "Ż���Ͻ� ��� ���� ���������� ���� �����ϱ� ������ �ƽ��Ե� ���� �ذ��� �帱 ���� �����. �Ф�"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "Ż�� �Ͻ� ��� �˾�â���� ���� ���Ǹ� �帮��, �� Ȯ�����ּ���."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "142",
                    Keyword = "��Ÿ �Ҹ�",
                    Question = "����Ʈ�� ��������.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "����Ʈ�� ������ٴ�!!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "���� �Ŵ����Կ��� �������ּ���. �ذ�å�� ã���ֽ� ������."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "211",
                    Keyword = "����",
                    Question = "����Ʈ ������ �˰�;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "������ ����Ʈ�� �����̱���!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "���� ����Ʈ�� '����Ʈ ����' ȭ�� �ϴ��� '����'���� ����Ͻ� �� �־��."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "���� �� ���� ���ó�� ���� �Ŷ�� �ϴϱ�, ������ּ���! >��<"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "311",
                    Keyword = "����Ʈ ������",
                    Question = "������ �ȵƾ��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�̷�����.. �� �ذ��� �帱����!!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�ٷ����� ���� ������ ��쿡��, �ٷ����� ȭ�� ���� ���� �����ż� �ش� ����翡 ���Ǹ� �Ͻø� ���ϰ� �亯�� ������ �� �ֱ���."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "�� ���� ������ ������ ���� �ʾҴٸ�, �Ŵ����Կ��� ������ּ���. "
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "321",
                    Keyword = "���� �Ϲ�",
                    Question = "���� ����Ʈ ���� �ʹ� �����.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "����Ʈ�� �� ���� �� �ִ� ����� �־��!!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�ٷ����� ������ ���� 100����Ʈ���� ���� 2000����Ʈ ������ �� ���� ������ �� �ִ�ϴ�. "
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "���� �õ��غ�����!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "411",
                    Keyword = "�ڵ� ���",
                    Question = "����� ī�带 �ڵ����� ����ϰ� �;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "����� ī��� ī���� ��ȣ�� ���ڵ带 �̿��ؼ� ���� ����ؼ� ����ؾ� �ؿ�."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�����̳� ģ���� �����ī�带 �Բ� ����ؼ� ����Ͻ� ���� �ִ�ϴ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "412",
                    Keyword = "��Ÿ ���",
                    Question = "�ſ�ī�带 ����ϰ� �;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�ƽ��Ե�, �ſ�ī�� ��� �� ����� ���� �������� �ʰ� �־��."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�� �� �پ��� ����� �߰� �� �����̴�, ������ּ���!!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "413",
                    Keyword = "��Ÿ ���",
                    Question = "���ڵ尡 ���µ� ��� ����� �˰� �;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "����� ����� �̷���!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = @"https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2Fmadupfinket%2Fposts%2F1658200141137008&width=500"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "�ش� ���̽��� ��ũ�� Ÿ�� ���ø�, ������� ��� ���� �� �� �־��."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "414",
                    Keyword = "����Ʈ ��ȸ",
                    Question = "����� ����Ʈ�� ��ȸ�ϰ� �;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "����.. ���� ����� ����Ʈ �ڵ� ��ȸ ����� �������� �ʰ� �ִ�ϴ�."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "���� �� �پ��� ����Ʈ ��ȸ, ���� �� ��� ����� �߰��ǰ� ������ �����ε� �� ��Ź�����!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "511",
                    Keyword = "����",
                    Question = "��ǰ ��� ����� �˰�;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "������ ���� �״�, �� ���!!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�����Ͻ� ��ǰ�� �ش� ���忡�� �������� ������ �����ִ� ������ ����Ͻ� �� �־��."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "��������Ʈ�� ��ȭ��ǰ���� �����ؼ� ���� ���� �ִ�ϴ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "512",
                    Keyword = "��� ����",
                    Question = "��� ������ Ȯ���ϰ� �;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "��� ������ �ñ��ϽŰ���?"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "���Ͼ��ø����̼� > ����Ʈ ���� > ���� > ���� �ϴ��� ���� ��ǰ �����Կ��� ���� �� ��� ������ Ȯ���Ͻ� �� �־��."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "����, ��ǰ���� ��� �ش� �����̳� ���� ����Ʈ���� Ȯ�ε� �����ϴ�ϴ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "513",
                    Keyword = "��ǰ ��ȯ",
                    Question = "�ٸ� ��ǰ���� ��ȯ�ϰ� �;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "��ǰ ��ȯ��, �̹� �����Ͻ� ��ǰ�� ����Ͻ� �� �籸�� �Ͻø� �˴ϴ�."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�켱, �Ŵ����Կ��� ��ǰ ��Ҹ� �������ּ���. :]"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "514",
                    Keyword = "���ó",
                    Question = "���� ���� ���� ������ ����ϰ� �;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�̷�.. ���ϻ������δ� �����ϽŰű���!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "���� �� �پ��� ��ǰ �� �Һ�ó�� ����� ���� ����ϰ� ������ ���ݸ� �� ��ٷ��ּ���!"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "�̿ܿ��� ��ǰ�� ���Ÿ� ���ؼ� ����Ͻô� ����� �ִ�ϴ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "515",
                    Keyword = "����",
                    Question = "���ǸӴ� ��ǰ�� ������ �˷��ּ���.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "���ǸӴ� ������ �ñ��ϽŰű���!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�켱, ���ǸӴϻ�ǰ�� Ȩ������ �湮 > �α��� > Ȩ������ ����� '��ǰ��' > '��ǰ�� ��ȯ��' Ŭ�� > '���̳ѹ�'�� �������ּ���. "
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "�׸��� ��ȯ�ǹ�ȣ(�� ��ȣ 12�ڸ�)�Է� > Ȯ�ι�ư�� �����ø� �޴������� 16�ڸ� �ɹ�ȣ�� �������� Ȯ���Ͻ� �� �ִ�ϴ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "521",
                    Keyword = "����",
                    Question = "��ǰ�� ��� ����� �˰�;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "��ǰ�� ��� �����̽ñ���."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "��ǰ���� �ش� ���忡�� ���� ���ø����̼� �� '������'�� �ش� ��ǰ�� ���ڵ带 �����ֽø� ��ȯ Ȥ�� ����� �����ؿ�. "
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "��, ��ȭ��ǰ�ǰ� ���ǸӴϴ� �¶��ο��� ������ȣ�� �̿��� ������ �����ϴ�ϴ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "522",
                    Keyword = "����",
                    Question = "��ǰ�� ������ ��� �ϳ���?",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "��ǰ�� ������ ������. �ϴ� ��� ������ ������ �湮�� �ּ���."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�׸���, �ش� ���忡�� ���� ���ø����̼� �� '������'�� �ش� ��ǰ�� ���ڵ带 �����ֽø� ��ȯ Ȥ�� ����� �����ؿ�. "
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "��ȭ��ǰ�ǰ� ���ǸӴϴ� ������ ���� ���� �¶������� �����Ͻ� ���� ������."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "523",
                    Keyword = "���ѿ���",
                    Question = "��ǰ�� ������ �������Ⱦ��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "���� ����, ������ �������ȱ���."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "��ǰ���� '1ȸ�� ���� 30�� ����'�� �����ϴ�ϴ�. ���� ���� �� ���� �ȿ� ������ּ���."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "��, ���޻����� ����ó���� ��û�ϱ� ���� �Ŵ����Բ� ��ȿ�Ⱓ�� ���� ��ǰ�� ��ȣ�� ���� ���� �����ּ���. :]"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "524",
                    Keyword = "�ܾ� Ȯ��",
                    Question = "����� ��ǰ�� ��� �ܾ��� �˷��ּ���.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "��ǰ�� �ܾ��� �ñ��ϽŰ���??"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�ܾ� Ȯ���� ��ǰ�� ����� ������ ��� ���忡���� ��ǰ�� ��ȣ�� �����Ͻø� Ȯ���� �����ϴ�ϴ�. :]"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "611",
                    Keyword = "ȭ�� ����",
                    Question = "ȭ���� ������.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "ȭ���� ���߽� ��쿡�� ȸ���Բ��� ����ϰ� ��ô� �޴���ȭ ������ ������ �Ǵ� ȭ���� ĸ���ؼ� service@finket.co.kr�� �����ּ���."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�������� �Բ� ������ ã�Ƽ� ��! �ذ��ص帮�ڽ��ϴ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "612",
                    Keyword = "����Ʈ ����",
                    Question = "���ȭ�� ���� �� ����Ʈ�� ������ �ʾƿ�.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "������� ����Ʈ�� ��� ��Ż��°� ������ ��Ȥ ���� ������ �߻��մϴ�."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "��Ż��¸� üũ���ֽð�, ���� ������ ���������� �߻��ϴ� ���, �Ŵ����Բ� ����Ͻô� �޴��� ������ ���� ������ �����ֽø� ���� ���� ���� ó���ص帱����!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "711",
                    Keyword = "���ǻ���",
                    Question = "���ǻ����� �ִµ���.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "Wow!! ȸ������ ��¦�̴� ���̵��� ������ ȯ���Դϴ�!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�Ŵ����Բ� ���̵� �����ֽø� ���� �� ���� ���񽺰� �� �� ����������."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "721",
                    Keyword = "Ż��",
                    Question = "Ż���ϴ� ����� �˰�;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�̷�.. ȸ���� �� �����ž� �Ͻó��� ;��;"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "Ż��� ������ �� ���� ������ ���� �����Ͻ� �� ������, Ż�� �� ���� ����Ʈ�� �Ҹ�ǿ���, �� �� �� ������ּ���."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "�� ���� ������� �� �� �ְ�, ������ �ϰ��ְڽ��ϴ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "722",
                    Keyword = "��ȣ/��� ����",
                    Question = "��ȣ/��⸦ �����ϰ� ������ ����;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�Ϳ�. ��ȣ�� ��⸦ �����ϼ̳���??"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "��ü�Ͻ� �޴����� ������ ��ġ�Ͻ� �� ������ ����Ͻô� ���̵�� �α��� �Ͻø� �״�� ����Ͻ� �� �־��."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "��, �ƽ��Ե� ���� �������� �������� �ʴ´�ϴ�. �Ф� �� ���������ε� ã�ƺɲ���!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "731",
                    Keyword = "�缳ġ",
                    Question = "�缳ġ �� ���� ���� ����Ʈ�� ��� �� �� �ֳ���?",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�缳ġ�� �ϼ̱���. �翬�� �״�� ��� �����ϼ���!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�缳ġ �� ������ ����ϼ̴� ���̵�� �α��� �Ͻø� �ȴ�ϴ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "741",
                    Keyword = "�α���",
                    Question = "�α��� �ϰ�;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�α����� �ȵǽó���??"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "��� ������ ������ �ְų�, ȸ���� ����� ��Ż��°� ������ �� �ֽ��ϴ�. ��� �� �ٽ� �������ּ���."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "�׷��� ������ �α����� ���� �ʴ´ٸ�, �Ŵ����Բ� ������ ������ �Բ� ���� �ֽø� �ذ��� �帱������."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "742",
                    Keyword = "�α׾ƿ�",
                    Question = "�α׾ƿ� �ϰ�;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�α׾ƿ��� ���Ͻó���?"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�α׾ƿ� ����� '���� �� ����' > '����ڼ���' > '���� ����' �� ���ż� �α׾ƿ� ��ư�� �����ø� �ȴ�ϴ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "743",
                    Keyword = "���̵�/��й�ȣ �н�",
                    Question = "���̵�(��й�ȣ)�� �˷��ּ���.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "����. ���̵� ��й�ȣ�� �ؾ�����̱���. �����ƿ�. ���� �κ������� ���� �׷���ϴ�."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "���̵�� '����� ����>��������'�� ���ż� Ȯ���� �����ϱ���. ��й�ȣ�� ��ȣȭ �Ǿ��־ ������ ���ּž� �Ѵ�ϴ�."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "�α��� ȭ�� �ϴ��� '�α��� ������ �����̳���?�� ���� �̸����� �����Ͻð� �� ��й�ȣ�� �Է��Ͻø� �ſ�."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "744",
                    Keyword = "���̵� ����",
                    Question = "���̵� ������ �ϰ�;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "���̵� �����ϰ� �����ñ���."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�ƽ��Ե� ���̵�� �������� �� �޴����� �����Ǿ� ������ �Ұ����մϴ�."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "���� ������ Ư���� ���� ������ ��ٷο� �� ���� ��Ź�����."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "745",
                    Keyword = "��й�ȣ ����",
                    Question = "��й�ȣ�� �����ϰ�;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "��й�ȣ ��������?"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�α��� ȭ�� �ϴ��� '�α��� ������ �����̳���?'�� ������ �� �̸��� ������ ���� �����Ͻ� �� �־��."
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "746",
                    Keyword = "�̸� ����",
                    Question = "�̸��� �ٲٰ� �;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�̸��� �ٲٰ� �����ñ���! ���� �� �̸� '��'�� ���� 'Ĺ'���� ���ٰ� ��ģ��ϴ�."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "�����Ͻð� ���� �̸��� �Ŵ����Բ� �����ּ���. �׷� �ٷ� ó���ص帱������!"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "747",
                    Keyword = "���ȭ��",
                    Question = "���ȭ���� �����ϰ�;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "���ȭ���� �����ϼ̳���??"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "���ȭ�� ������ ���� ���ø����̼��� ���� �Ͻ� �� '����� ����' > '���ȭ�� ����' ���� �Ͻ� �� �ִ�ϴ�."
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "���ȭ���� ���ؼ� �������� �а� �߰� ����Ʈ�� �������� �� ������ �� �� �� �������ּ���! :]"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "748",
                    Keyword = "���ȭ��",
                    Question = "���ȭ�� ����Ʈ ���� �ֱ⸦ �˰�;��.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "��! ����Ʈ ���� �ֱ�� �� ����ε���!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "���� �����帮�°ǵ�, ��ʺп� 2~3����Ʈ ���� ���δ�ϴ�. ���� ���� ���ø� �ξ�! ���� ���̰���?"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "749",
                    Keyword = "����",
                    Question = "������ �������ּ���.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "��! �����̿�? ������ ���� ��̳� �̾߱�� ��!"
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2Fmadupfinket%2Fposts%2F1645271335763222&width=500"
                        },
                        new Answer
                        {
                            Order = 30,
                            Text = "���� ��ũ�� �����ø� ���̽����� ���� ���������� ������ ������ ������ �� ���� ���� �� �־��. :]"
                        }
                    }
                },
                new ExecutiveQuestion
                {
                    Code = "751",
                    Keyword = "������",
                    Question = "�����͸� �˷��ּ���.",
                    Answers = new System.Collections.Generic.List<Answer>()
                    {
                         new Answer
                        {
                            Order = 10,
                            Text = "�����ʹ� �� �� ���� ������� �̿��Ͻ� �� �־��."
                        },
                        new Answer
                        {
                            Order = 20,
                            Text = "1. ������ ����ø� �Ǳ���! 2. �Ŵ����Կ��� ����ø� ���� �����͵帰 ���� ���͵帱������. �׸��� 3. īī�� �÷��� ģ������ 'finket'�� �˻��Ͻø�, �Ŵ����԰� ��ȭ�� �����ϴ�ϴ�. ]"
                        }
                    }
                }

            );

            //// -----------------------------------------------------------
            context.CommentDefinitions.AddOrUpdate(p => p.Code,
                new CommentDefinition
                {
                    Catetory = "Greetings",
                    Code = "RGB01",
                    Definition = "�⺻ �λ�",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "�ȳ��ϼ���! :]"
                        },
                        new Comment
                        {
                            Text = "��! �θ��̳���, ȸ����?"
                        },
                        new Comment
                        {
                            Text = "���� ã���̴ٰ� ������."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Introduce",
                    Code = "RIB01",
                    Definition = "�� �Ұ�",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "ȸ������ ���͵帮�� �� '��'�̶�� �ؿ�!"
                        },
                        new Comment
                        {
                            Text = "���� ���̿���. ȸ������ ģ����."
                        },
                        new Comment
                        {
                            Text = "ȸ������ �� �θ� ����.. ���纼����."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "PreProposal",
                    Code = "RPB01",
                    Definition = "���� �� ��Ʈ",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "���� ���͵帱 �� �ִ� ������ �����帱����."
                        },
                        new Comment
                        {
                            Text = "���� �̷� �������� ���� ���� ã���ô��󱸿�."
                        },
                        new Comment
                        {
                            Text = "�� �߿� �� ã�� ������ ������ ���ڳ׿�."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Confirm",
                    Code = "RCB01",
                    Definition = "Ȯ�� ��Ʈ",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "���� ������ {0} �³���?"
                        },
                        new Comment
                        {
                            Text = "�����Ͻ� �׸��� {0}����?"
                        },
                        new Comment
                        {
                            Text = "{0}�� ���� �����ϼ̱���."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Confirm",
                    Code = "SCU01",
                    Definition = "Ȯ�� ��Ʈ",
                    Owner = "User",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "��, �¾ƿ�!"
                        },
                        new Comment
                        {
                            Text = "�ƴѵ���?"
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Request",
                    Code = "SRU01",
                    Definition = "��Ÿ ��û",
                    Owner = "User",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "�Ʊ� �ߴ� �� �ٽ� ���ּ���!"
                        },
                        new Comment
                        {
                            Text = "�Ŵ��������� �������."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Proposal",
                    Code = "RPB02",
                    Definition = "�߰� ���Ƚ�",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "���� �� �ڼ��� �������ּ���."
                        },
                        new Comment
                        {
                            Text = "�׷��ٸ� �̷� �����̰ڱ���."
                        },
                        new Comment
                        {
                            Text = "�����Ͻ� ������ �̷� �͵�� ���谡 �־��."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Proposal",
                    Code = "RPB03",
                    Definition = "���� ���Ƚ�",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "Ȥ�� �ñ��Ͻ� ������ �̰� �ƴѰ���?"
                        },
                        new Comment
                        {
                            Text = "������ ����� ���� ������ �̰ǰ���?"
                        },
                        new Comment
                        {
                            Text = "������ �� �ȿ� �ִ�!"
                        },
                        new Comment
                        {
                            Text = "�Ƹ��� �̷� ������ �ñ��Ͻ� �� ��������!"
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Proposal",
                    Code = "RPB04",
                    Definition = "�����",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "����.. �츮��������... �� �亯 ã�Ҿ��."
                        },
                        new Comment
                        {
                            Text = "�� ����� ����������, �˰� �ִ� �����̿���!"
                        },
                        new Comment
                        {
                            Text = "�̷� ������ ������?! �׷��ٸ�.."
                        },
                        new Comment
                        {
                            Text = "���� ������. �亯�ص帱����."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Confirm",
                    Code = "RCB02",
                    Definition = "������",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "���� ����� �亯�� ��ȳ���??"
                        },
                        new Comment
                        {
                            Text = "�ñ��� �� �� �ذ�Ǽ���?"
                        },
                        new Comment
                        {
                            Text = "���� �� �ȶ��Ѱ�����."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Confirm",
                    Code = "RCB03",
                    Definition = "�����ذ��",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "����. ���� ���� �뼼 �ΰ������̿���."
                        },
                        new Comment
                        {
                            Text = "�����̳׿�. �� ����� �̾߱� ������ ��� ������!! �� ���� �Ŵ����Կ��� �������ּ���! :]"
                        },
                        new Comment
                        {
                            Text = "�Ϳ� ���õ� ���� �� �� �� ���Ƽ� ���ƿ�!"
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Exception",
                    Code = "REB01",
                    Definition = "����� �Է� ����",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "���� �ƴ� ������ �ƴϿ���. ������ ����ּ���."
                        },
                        new Comment
                        {
                            Text = "���� �����帰 ���� �ȿ��� ����ּ���."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Exception",
                    Code = "REB02",
                    Definition = "���ܻ��� ����",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "���� ���� �ѱ��� ��Ⱑ ��������. ���ڷ� �����ּ���."
                        },
                        new Comment
                        {
                            Text = "�˾Ƶ��� ���߾��. ���ڷ� �����ּ���."
                        },
                        new Comment
                        {
                            Text = "�߸� �Է��ϼ̾��! ���ڷ� �����ּ���."
                        }
                    }
                },
                new CommentDefinition
                {
                    Catetory = "Bye",
                    Code = "RBB01",
                    Definition = "���� ��Ʈ",
                    Owner = "Bot",
                    Comments = new System.Collections.Generic.List<Comment>()
                    {
                        new Comment
                        {
                            Text = "�׷�, ������ �� ����~~"
                        },
                        new Comment
                        {
                            Text = "�ʿ��Ͻ� �� ������ �ҷ��ּ���!"
                        },
                        new Comment
                        {
                            Text = "�����̳׿�! �� �ɲ���. �̸�����~"
                        }
                    }
                }
            );
        }
    }
}
