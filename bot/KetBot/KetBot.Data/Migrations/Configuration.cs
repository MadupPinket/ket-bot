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
                            QuestionId = 1,
                            Text = "�����Ͻ� ������ �ֽ� �� �������� ��ġ�� ����Ǿ����ϴ�. ���� ������ �õ��غ�����. :]"
                        },
                        new Answer
                        {
                            Order = 20,
                            QuestionId = 1,
                            Text = "1. ������ ��ġ�� �� ����\n 2. ���� �÷��� ������ �ֽ� �������� �缳ġ"
                        },
                        new Answer
                        {
                            Order = 30,
                            QuestionId = 1,
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
                            QuestionId = 1,
                            Text = "�����Ͻ� ������ �ֽ� �� �������� ��ġ�� ����Ǿ����ϴ�. ���� ������ �õ��غ�����. :]"
                        },
                        new Answer
                        {
                            Order = 20,
                            QuestionId = 1,
                            Text = "1. ������ ��ġ�� �� ���� 2. ���� �÷��� ������ �ֽ� �������� �缳ġ"
                        },
                        new Answer
                        {
                            Order = 30,
                            QuestionId = 1,
                            Text = "���Ŀ��� ������ ������ �߻��Ѵٸ�, �Ŵ������� ������ּ���!!"
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
                }
                //,
                //new CommentDefinition
                //{
                //    Catetory = "",
                //    Code = "",
                //    Definition = "",
                //    Owner = "",
                //    Comments = new System.Collections.Generic.List<Comment>()
                //    {
                //        new Comment
                //        {
                //            Text = ""
                //        },
                //        new Comment
                //        {
                //            Text = ""
                //        },
                //        new Comment
                //        {
                //            Text = ""
                //        }
                //    }
                //}
            );

            //// -----------------------------------------------------------
        }
    }
}
